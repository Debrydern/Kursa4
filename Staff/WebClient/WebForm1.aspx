<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Персональные данные сотрудников</title>    
    <link rel="stylesheet" href="StyleSheet1.css" />
</head>
<body>
    <h3>Перпсональные данные сотрудников:</h3>
    
    <form id="form1" runat="server">
        <div id="table_row">
            <asp:Label ID="Label1" runat="server" Text="Введите фамилию для поиска:"></asp:Label>
            <br />
            <asp:TextBox ID="LastNameBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="FindBtn" runat="server" Text="Поиск" OnClick="FindBtn_Click" />
        </div>
        <br />
        <asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label>

    </form>
    <br />
    <table id="table1">
        <tr>
            <th>LastName    </th>
            <th>FirstName</th>
            <th>PatronicName</th>
            <th>Age</th>
            <th>Birthday</th>
            <th>Post</th>
            <th>Departament</th>
        </tr>
        <%if (getShort!=null)
          {
                for (int i = 0; i < getShort.Length; i++)
                {
            %>
        <tr>
            <td><%=getShort[i].Last_name %></td>
            <td><%=getShort[i].First_name %></td>
            <td><%=getShort[i].Patronic_name %></td>
            <td><%=getShort[i].Age %></td>
            <td><%=getShort[i].Birthday.ToShortDateString() %></td>
            <td><%=getShort[i].Post %></td>
            <td><%=getShort[i].Department %></td>
        </tr>
        <%      }
          } %>
       
        </table>
           
   
</body>
</html>
