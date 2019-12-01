<%@ Page Title="Product Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="ProductDetails.aspx.cs" Inherits="FoodStore.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceholderID="MainContent" runat="server">
    <asp:FormView ID="productDetail" runat="server" ItemType="FoodStore.Models.Product" SelectMethod="GetProduct" RenderOuterTable="false" OnPageIndexChanging="productDetail_PageIndexChanging">
        <ItemTemplate>
            <div>
                <h1><%#:Item.ProductName%></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Images/<%#:Item.ImagePath %>" style="border:solid; height:300px" alt="<%#:Item.ProductName %>" />
                    </td>
                    <td>&nbsp</td>
                    <td style="vertical-align: top; text-align: left;">
                     <%--   <%--<b>Description:</b><br /><%#:Item.Description %>
                        <br />--%>
                        <%--<span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %><br />
                         <b>Units:</b>&nbsp;<%#: String.Format("{0}", Item.UnitsInStock) %><br />
                        <%#Item.UnitsInStock == 0 %></span>--%><br />--%>

                    </td>                         
                        <%--<b>Units:</b>&nbsp;<%#: String.Format("{0}", Item.UnitsInStock) %><br />
                        <%#Item.UnitsInStock == 0 %></td> --%>
                </tr>
            </table>
        </ItemTemplate>
        </asp:FormView>
</asp:Content>