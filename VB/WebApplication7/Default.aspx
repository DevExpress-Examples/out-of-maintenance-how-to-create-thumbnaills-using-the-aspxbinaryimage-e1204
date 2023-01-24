<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication7._Default" %>

<%@ register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web"
	TagPrefix="dxpc" %>

<%@ register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web"
	TagPrefix="dxe" %>

<%@ register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web"
	TagPrefix="dxwgv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dxwgv:aspxgridview ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="AccessDataSource1" KeyFieldName="EmployeeID">
			<columns>
				<dxwgv:gridviewdatatextcolumn FieldName="EmployeeID" ReadOnly="True" VisibleIndex="0">
					<editformsettings Visible="False" />
				</dxwgv:gridviewdatatextcolumn>
				<dxwgv:gridviewdatatextcolumn FieldName="LastName" VisibleIndex="1">
				</dxwgv:gridviewdatatextcolumn>
				<dxwgv:gridviewdatatextcolumn FieldName="FirstName" VisibleIndex="2">
				</dxwgv:gridviewdatatextcolumn>
				<dxwgv:gridviewdatatextcolumn FieldName="Photo" VisibleIndex="3">
					<dataitemtemplate>
						<dxe:aspxbinaryimage ID="ASPxBinaryImage1" runat="server" Value='<%#GetThumbnail(Eval("Photo"))%>'>
						</dxe:aspxbinaryimage>
					</dataitemtemplate>
				</dxwgv:gridviewdatatextcolumn>
			</columns>
		</dxwgv:aspxgridview>
		<asp:accessdatasource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
			SelectCommand="SELECT [EmployeeID], [LastName], [FirstName], [Photo] FROM [Employees]">
		</asp:accessdatasource>
		&nbsp;<br />
	</div>
	</form>
</body>
</html>
