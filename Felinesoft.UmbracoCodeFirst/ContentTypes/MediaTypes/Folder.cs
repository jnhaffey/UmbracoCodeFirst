using Felinesoft.UmbracoCodeFirst;
using Felinesoft.UmbracoCodeFirst.DataTypes;
using Felinesoft.UmbracoCodeFirst.Attributes;
using Felinesoft.UmbracoCodeFirst.Extensions;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;
using Felinesoft.UmbracoCodeFirst.DataTypes.BuiltIn;
using Felinesoft.UmbracoCodeFirst.ContentTypes;

namespace Felinesoft.UmbracoCodeFirst.ContentTypes
{
    [CodeFirstCommonBase]
    public abstract class MediaFolderBase : MediaTypeBase
    {
		public class ContentsTab : TabBase
		{
			[ContentProperty(@"Contents:", @"contents", false, @"", 0, false)]
			public virtual Felinesoft.UmbracoCodeFirst.DataTypes.BuiltIn.ListView_Media Contents { get; set; }

		}

		[ContentTab(@"Contents", 1)]
		public virtual ContentsTab Contents { get; set; }
	}

    [MediaType("Folder", "Folder", new Type[] { typeof(MediaFolder), typeof(MediaImage), typeof(MediaFile) }, "icon-folder", true, false, "")]
    [BuiltInMediaType]
    public class MediaFolder : MediaFolderBase
    {

    }
}