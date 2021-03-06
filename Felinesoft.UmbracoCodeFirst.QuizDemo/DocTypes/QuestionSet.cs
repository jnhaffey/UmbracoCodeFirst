using Felinesoft.UmbracoCodeFirst.ContentTypes;
using Felinesoft.UmbracoCodeFirst.Attributes;
using Felinesoft.UmbracoCodeFirst.DataTypes.BuiltIn;
using Felinesoft.UmbracoCodeFirst.Linq;
using Felinesoft.UmbracoCodeFirst.QuizDemo.MediaTypes;

namespace Felinesoft.UmbracoCodeFirst.QuizDemo.DocTypes
{
	//The ListViewDocumentType automatically adds the specified generic doc type to AllowedChildren, in this case typeof(Question). 
	//It will be the *only* allowed type, so that the IEnumerable<T> & IList<T> interfaces are properly honoured.
	[DocumentType(enableListView: true, allowAtRoot: false)]
	[EventHandler(typeof(QuestionSetSurfaceController))]
	[Template(true)]
	public class QuestionSet : ListViewDocumentType<Question>
	{
		public class ContentTab : TabBase
		{
			[ContentProperty]
			public virtual RichtextEditor WelcomeParagraph { get; set; }

			[ContentProperty(mandatory: false)]
			public virtual SingleMediaPicker<QuestionImageMedia> DefaultImageForSet { get; set; }
		}

		[ContentTab]
		public ContentTab Content { get; set; }
	}
}