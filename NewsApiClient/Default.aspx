<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NewsApiClient._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid bg-3 text-center">
        <div class="container divStyle margin">
            <h1 class="margin">News</h1>
           
            <asp:DataList EnableViewState="true" ID="newsDataList" runat="server">

                <ItemTemplate>

                    <div class="container well" style="background-color:#ebe6e0; color:#301F0D" id="items">
                        <div class="row">
                            <div class="col-sm-1"></div>
                            <div class="col-sm-3" ><br />
                                <img class="img-thumbnail"  src="<%#Eval("urlToImage") %>" />                               
                            </div>
                            <div class="col-sm-1">
                            </div>
                            <div class="col-sm-6">
                                <h3><%#Eval("title") %></h3>
                                <br />
                                <p><%#Eval("description") %></p>
                            
                               
                                
                          </div>
                        </div>                 
                    </div>
                    <br />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>

</asp:Content>
