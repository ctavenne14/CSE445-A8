<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h3>
              XML Serivce TryIt </h3>
            <h4>
                Takes URL of XML file and URL of XSD file and verifies it and also gets contents of inputted key.</h4>
    <p>XML Input:<asp:TextBox ID="TextBox1" runat="server" Width="315px">http://www.public.asu.edu/~ctavenne/Books.xml</asp:TextBox>
&nbsp;<p>XSD Input:<asp:TextBox ID="TextBox2" runat="server" Width="315px">http://www.public.asu.edu/~ctavenne/Books.xsd</asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="Verfify" OnClick="Button1_Click" />
        
    </p>
    <p>Verification Status:
        <asp:Label ID="lblUpload" runat="server"></asp:Label>
    </p>
    <p>XML Input:<asp:TextBox ID="TextBox3" runat="server" Width="315px">http://www.public.asu.edu/~ctavenne/Books.xml</asp:TextBox>
&nbsp;<p>XSL Input:<asp:TextBox ID="TextBox4" runat="server" Width="315px">http://www.public.asu.edu/~ctavenne/Books.xsl</asp:TextBox>
&nbsp;<asp:Button ID="Button2" runat="server" Text="Transform" OnClick="Button2_Click" />
        
    </p>
    <p>Generated HTML:
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
        
    <p>Book information gathered from https://www.barnesandnoble.com/b/books/_/N-1fZ29Z8q8
    </p>
</asp:Content>
