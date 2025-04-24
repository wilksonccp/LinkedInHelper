﻿namespace LinkedInHelper;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        cmbTipoResposta.Items.Add("Convite Aceito - Recrutador Nacional");
        cmbTipoResposta.Items.Add("Convite Aceito - Recrutador Internacional");
        cmbTipoResposta.Items.Add("Convite Aceito - Profissional Nacional");
        cmbTipoResposta.Items.Add("Convite Aceito - Profissional Internacional");
        cmbTipoResposta.Items.Add("Aceitando Convite - Recrutador Nacional");
        cmbTipoResposta.Items.Add("Aceitando Convite - Recrutador Internacional");
        cmbTipoResposta.Items.Add("Aceitando Convite - Profissional Nacional");
        cmbTipoResposta.Items.Add("Aceitando Convite - Profissional Internacional");

        cmbTipoResposta.SelectedIndex = 0;
    }

    private void btnGerarCopiar_Click(object sender, EventArgs e)
    {
        string nome = txtNomePessoa.Text.Trim();
        if (string.IsNullOrWhiteSpace(nome))
        {
            MessageBox.Show("Por favor, digite o nome da pessoa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string tipo = cmbTipoResposta.SelectedItem.ToString();

        string mensagem = tipo switch
        {
            "Convite Aceito - Recrutador Nacional" =>
$@"Olá {nome}, obrigado por aceitar meu convite!

Atualmente, atuo como desenvolvedor backend freelancer com foco em C# e .NET.

Embora minha preferência seja por vagas remotas, também estou aberto a modelos híbridos ou presenciais, desde que o projeto permita uma boa contribuição da minha parte.

Se houver alguma vaga que se alinhe ao meu perfil, será um prazer conversar!",

            "Convite Aceito - Recrutador Internacional" =>
$@"Hi {nome}, thank you for accepting my invitation!

I'm currently working as a freelance backend developer, focused on C# and .NET.

Although I prioritize remote roles, I'm also open to hybrid or on-site opportunities — especially when the project is engaging and I can add value.

If there's an opportunity that matches my profile, I’d be happy to connect further!",

            "Convite Aceito - Profissional Nacional" =>
$@"Oi {nome}, obrigado por aceitar meu convite!

Atuo como desenvolvedor backend freelancer, com foco em C# e .NET.

Gosto muito de trocar ideias e fortalecer minha rede com profissionais da área — acredito que essa troca nos ajuda a crescer juntos.

Vamos manter contato!",

            "Convite Aceito - Profissional Internacional" =>
$@"Hi {nome}, thanks for connecting!

I'm currently working as a freelance backend developer, specialized in C# and .NET.

I really value knowledge exchange and staying connected with fellow professionals — looking forward to sharing experiences and growing together!",

            "Aceitando Convite - Recrutador Nacional" =>
$@"Olá {nome}, obrigado pelo contato!

Sou desenvolvedor backend freelancer, com especialização em .NET, e estou em busca de oportunidades remotas, híbridas ou presenciais, conforme o alinhamento do projeto.

Ficarei feliz em saber mais sobre as vagas com as quais você está trabalhando!",

            "Aceitando Convite - Recrutador Internacional" =>
$@"Hi {nome}, thank you for reaching out!

I'm a backend developer specialized in .NET, currently working as a freelancer.

While I’ve focused on remote roles, I'm also open to hybrid or on-site opportunities — especially when I can contribute meaningfully to the team.

I’d love to hear more about the positions you’re recruiting for!",

            "Aceitando Convite - Profissional Nacional" =>
$@"Olá {nome}! Que bom poder me conectar com você por aqui. 😊

Atuo como desenvolvedor backend freelancer, com foco em C# e .NET, e estou sempre em busca de evolução técnica e profissional — inclusive aprimorando meu inglês.

Gosto muito de trocar experiências com colegas da área. Toda dica, insight ou ideia é muito bem-vinda!

Um grande abraço e sucesso nos seus projetos!",

            "Aceitando Convite - Profissional Internacional" =>
$@"Hi {nome}! I'm glad to connect with you here on LinkedIn. 😊

I'm currently working as a freelance backend developer, specialized in C# and .NET, and I’m constantly looking to grow technically and professionally.

I truly value exchanging insights with other professionals — I'm always open to sharing and learning together.

Wishing you success in your projects! Feel free to reach out anytime!",

            _ => "Tipo de mensagem não encontrado."
        };

        Clipboard.SetText(mensagem);
        textDone.Text = "Mensagem copiada:\n\n" + mensagem;
    }
}
