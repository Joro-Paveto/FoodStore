<%@ Page Title="Product" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProductList.aspx.cs" Inherits="FoodStore.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%:Page.Title%></h2>
            </hgroup>

            <asp:ListView ID="productList" runat="server"
                DataKeyNames="productID" GroupItemCount="5"
                ItemType="FoodStore.Models.Product" SelectMethod="GetProducts" OnSelectedIndexChanged="productList_SelectedIndexChanged">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td />
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>                                                                      
                                    <img src="/Images/Thumbs/<%#:Item.ImagePath%>" 
                                         <width="100" height="75" style="border: solid" />
                                    
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <%--<a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">--%>
                                        <span>
                                            <b><%#:Item.ProductName%></b>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice)%> <br />
                                        <%--<b>Units:</b>&nbsp;<%#: String.Format("{0}", Item.UnitsInStock) %> <br />--%>                                          
                                    </span>
                                    <span runat="server" Visible='<%# (int)Eval("UnitsInStock")==0 %>'>Out of Stock
                                    </span>
                                    <span runat="server" Visible='<%# (int)Eval("UnitsInStock")!=0 %>'>
                                        <%#: String.Format("In Stock: {0}", Item.UnitsInStock)%>
                                    </span>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:auto;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>                                
                            </tr>
                            <tr></tr>                            
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>
