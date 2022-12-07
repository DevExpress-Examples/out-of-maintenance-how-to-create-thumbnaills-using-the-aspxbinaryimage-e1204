Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports System.IO
Imports DevExpress.Web

Namespace WebApplication7
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Public Function GetThumbnail(ByVal image As Object) As Byte()
			'create image from array of bytes----------------

			Dim array() As Byte = TryCast(image, Byte())
			Dim imageStream As New MemoryStream(array)
			Dim img As System.Drawing.Image = System.Drawing.Image.FromStream(imageStream)

			'------------------------------------------------

			'create thumbnail--------------------------------

			img = img.GetThumbnailImage(50, 50, New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback), IntPtr.Zero)

			'--------------------------------------------------

			'save thumnail to new stream---------------------
			Dim thumbnailStream As New MemoryStream(array)
			img.Save(thumbnailStream, System.Drawing.Imaging.ImageFormat.Bmp)

			'------------------------------------------------
			Return thumbnailStream.ToArray()

		End Function

		Public Function ThumbnailCallback() As Boolean
			Return True
		End Function


	End Class
End Namespace
