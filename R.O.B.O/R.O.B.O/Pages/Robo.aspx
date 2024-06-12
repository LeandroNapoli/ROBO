<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Robo.aspx.cs" Inherits="R.O.B.O.Pages.Robo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />
    <div class="container">
        <div class="row bg-danger">
            <label>Estados R.O.B.O</label>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="row">
                        <div class="col-md-12">
                            <div id="divBracoDireito" runat="server" class="col-md-4">
                                <asp:Label runat="server" CssClass="form-label">Estado Braço Direito</asp:Label>
                                <asp:TextBox runat="server" CssClass="form-control" ID="txtBracoDireito" Enabled="false">rotação</asp:TextBox>
                            </div>
                            <div id="divBracoEsquerdo" runat="server" class="col-md-4">
                                <asp:Label runat="server" CssClass="form-label">Estado Braço Esquerdo</asp:Label>
                                <asp:TextBox runat="server" CssClass="form-control" ID="txtBracoEsquerdo" Enabled="false">rotação</asp:TextBox>
                            </div>
                            <div id="divCabeca" runat="server" class="col-md-4">
                                <asp:Label runat="server" CssClass="form-label">Estado Braço Direito</asp:Label>
                                <asp:TextBox runat="server" CssClass="form-control" ID="txtCabeca" Enabled="false">inclinado</asp:TextBox>
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
