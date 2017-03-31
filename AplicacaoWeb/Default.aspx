<%@ Page Title="Gerenciador de Projetos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AplicacaoWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Gerencie seu Projeto</h1>
        <p class="lead">WebAplication de aprendizado desenvolvido em ASP.NET.<br>
            Aqui farei alguns testes para obter conhecimentos na ferramenta.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Entendendo</h2>
            <p>
                O gerenciador de projetos é uma ferramenta desenvolvida para dar mais performance, informatizar e obter uma melhor administração dos projetos da sua empresa.
            </p>
            </div>
        <div class="col-md-4">
            <h2>Vamos começar?</h2>
            <p>
                Vamos informatizar todos os projetos de sua empresa? Clique no botão para iniciar o gerenciamento.
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Iniciar" PostBackUrl="~/TelaInicial.aspx" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Contato</h2>
            <p>
                Tem alguma dúvida? Deseja fazer um orçamento ou recomendar alguém que esteja precisando informatizar algum processo dentro da empresa?<br>
                Nos envie um e-mail, teremos o maior prazer em responde-lo! Não exite e entre em contato conosco.
            </p>
        </div>
    </div>

</asp:Content>
