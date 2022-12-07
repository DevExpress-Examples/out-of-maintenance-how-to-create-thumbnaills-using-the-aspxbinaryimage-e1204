using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.IO;
using DevExpress.Web;

namespace WebApplication7
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public byte[] GetThumbnail(object image)
        {
            //create image from array of bytes----------------

            byte[] array = image as byte[];
            MemoryStream imageStream = new MemoryStream(array);
            System.Drawing.Image img = System.Drawing.Image.FromStream(imageStream);

            //------------------------------------------------

            //create thumbnail--------------------------------

            img = img.GetThumbnailImage(50, 50, new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);

            //--------------------------------------------------

            //save thumnail to new stream---------------------
            MemoryStream thumbnailStream = new MemoryStream(array);
            img.Save(thumbnailStream, System.Drawing.Imaging.ImageFormat.Bmp);

            //------------------------------------------------
            return thumbnailStream.ToArray();
            
        }

        public bool ThumbnailCallback()
        {
            return true;
        }

       
    }
}
