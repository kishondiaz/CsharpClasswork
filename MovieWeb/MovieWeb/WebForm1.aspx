<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MovieWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        First Name: <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldFirstName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First Name is required" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        <br />
        <br />
        Last Name: <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldLastName" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last Name is requied" Font-Bold="True" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        Age:
        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:RangeValidator ID="RangeValidatorAge" runat="server" ControlToValidate="txtAge" ErrorMessage="You must be between 18 and 65 years old" Font-Bold="True" ForeColor="#FF3300" MaximumValue="65" MinimumValue="18" Type="Integer"></asp:RangeValidator>
        <br />
        <br />
        <br />
        Full Name&nbsp;
        <asp:Label ID="lblFullName" runat="server" Text=""></asp:Label>
    
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    
    &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblDate" runat="server"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownListRatings" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourcwRatings" DataTextField="Rating" DataValueField="Rating">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourcwRatings" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [Rating] FROM [Ratings]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:GridView ID="GridViewMovies" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceMovies" OnSelectedIndexChanged="GridViewMovies_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" SortExpression="ID" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="ReleaseDate" HeaderText="ReleaseDate" SortExpression="ReleaseDate" />
                <asp:BoundField DataField="Rating" HeaderText="Rating" SortExpression="Rating" />
                <asp:BoundField DataField="Genre" HeaderText="Genre" SortExpression="Genre" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceMovies" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT Movies.ID, Movies.Title, Movies.ReleaseDate, Movies.Rating, Genre.Genre FROM (Movies INNER JOIN Genre ON Movies.Genre = Genre.ID) WHERE (Movies.Rating = ?)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownListRatings" Name="Rating" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
    
    </div>
    </form>
</body>
</html>
