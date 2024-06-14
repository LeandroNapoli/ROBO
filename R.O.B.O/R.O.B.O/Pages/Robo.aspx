<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Robo.aspx.cs" Inherits="R.O.B.O.Pages.Robo" Async="true" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />
    <div>
        <div>
            <label>Estados R.O.B.O</label>
            <div class="divider"></div>
            <div class="text-center">

                <div>
                    <label>Braço Direito</label>
                    <div runat="server" class="col-md-12">
                        <div class="col-md-4 form-check-inline">
                            <asp:Label runat="server" CssClass="form-label">Estado Cotovelo Direito</asp:Label>
                            <asp:TextBox runat="server" CssClass="form-control" ID="txtCotoveloDireito" Enabled="false">rotação</asp:TextBox>
                        </div>
                        <div class="col-md-4 form-check-inline">
                            <asp:Label runat="server" CssClass="form-label">Estado Pulso Direito</asp:Label>
                            <asp:TextBox runat="server" CssClass="form-control" ID="txtPulsoDireito" Enabled="false">rotação</asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="divider"></div>
                <div>
                    <label>Braço Esquerdo</label>
                    <div class="col-md-12">
                        <div class="col-md-4 form-check-inline">
                            <asp:Label runat="server" CssClass="form-label">Estado Cotovelo Esquerdo</asp:Label>
                            <asp:TextBox runat="server" CssClass="form-control" ID="txtCotoveloEsquerdo" Enabled="false">rotação</asp:TextBox>
                        </div>
                        <div class="col-md-4 form-check-inline">
                            <asp:Label runat="server" CssClass="form-label">Estado Pulso Esquerdo</asp:Label>
                            <asp:TextBox runat="server" CssClass="form-control" ID="txtPulsoEsquerdo" Enabled="false">rotação</asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="divider"></div>
                <div>
                    <label>Estado Cabeça</label>
                    <div class="col-md-12">
                        <div class="col-md-4 form-check-inline">
                            <asp:Label runat="server" CssClass="form-label">Estado Braço Direito</asp:Label>
                            <asp:TextBox runat="server" CssClass="form-control" ID="txtInclinacaoCabeca" Enabled="false">inclinado</asp:TextBox>
                        </div>
                        <div class="col-md-4 form-check-inline">
                            <asp:Label runat="server" CssClass="form-label text-start">Estado Braço Direito</asp:Label>
                            <asp:TextBox runat="server" CssClass="form-control" ID="txtRotacaoCabeca" Enabled="false">inclinado</asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="divider"></div>
                <button class="btn btn-primary" type="button" data-bs-toggle="collapse" data-bs-target="#divAlteração" aria-expanded="false" aria-controls="divAlteração">
                    Alterar estado R.O.B.O
                </button>
                <div class="m-1">
                    <div id="divAlteração" class="collapse">
                        <div class="card card-body">
                            <div class="col-md-12">
                                <div class="col-md-3 dropdown form-check-inline">
                                    <asp:Label runat="server" CssClass="text-start form-label">Pulso Direito</asp:Label>
                                    <asp:DropDownList runat="server" CssClass="form-select" ID="dpdPulsoDireito"></asp:DropDownList>
                                </div>
                                <div class="col-md-3 dropdown form-check-inline">
                                    <asp:Label runat="server" CssClass="form-label">Cotovelo Direito</asp:Label>
                                    <asp:DropDownList runat="server" CssClass="form-select" ID="dpdCotoveloDireito"></asp:DropDownList>
                                </div>
                                <div class="col-md-3 dropdown form-check-inline">
                                    <asp:Label runat="server" CssClass="text-start form-label">Pulso Esquerdo</asp:Label>
                                    <asp:DropDownList runat="server" CssClass="form-select" ID="dpdPulsoEsquerdo"></asp:DropDownList>
                                </div>
                                <div class="col-md-3 dropdown form-check-inline">
                                    <asp:Label runat="server" CssClass="form-label">Cotovelo Esquerdo</asp:Label>
                                    <asp:DropDownList runat="server" CssClass="form-select" ID="dpdCotoveloEsquerdo"></asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-12">

                                <div class="col-md-3 dropdown form-check-inline">
                                    <asp:Label runat="server" CssClass="text-start form-label">Inclinação Cabeça</asp:Label>
                                    <asp:DropDownList runat="server" CssClass="form-select" ID="dpdInclinacaoCabeca"></asp:DropDownList>
                                </div>
                                <div class="col-md-3 dropdown form-check-inline">
                                    <asp:Label runat="server" CssClass="form-label">Rotação Cabeça</asp:Label>
                                    <asp:DropDownList runat="server" CssClass="form-select" ID="dpdRotacaoCabeca"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
