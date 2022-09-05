<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="StudentWeb.StudentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Roll No"></asp:Label>
        <asp:TextBox ID="SRNINPUT" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="SNINPUT" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Age"></asp:Label>
            <asp:TextBox ID="SAINPUT" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Branch"></asp:Label>
            <asp:TextBox ID="SBINPUT" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="College"></asp:Label>
            <asp:TextBox ID="SCINPUT" runat="server"></asp:TextBox>
        </p>
        <asp:RadioButton ID="Male" runat="server" GroupName="GenderButton" Text="Male" />
        <asp:RadioButton ID="Female" runat="server" GroupName="GenderButton" Text="Female" />
        <p>
            <asp:RadioButton ID="MarriedButton" runat="server" GroupName="Status" Text="Married" />
            <asp:RadioButton ID="UnMarriedButton" runat="server" GroupName="Status" OnCheckedChanged="RadioButton4_CheckedChanged" Text="UnMarried" />
        </p>
        <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="Add" />
        <asp:Button ID="ButtonUpdate" runat="server" OnClick="ButtonUpdate_Click" Text="Update" />
        <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Delete" />
        <br />
        <asp:GridView ID="GridViewStudent" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridViewStudent_SelectedIndexChanged">
        </asp:GridView>
    </form>
</body>
</html>
