namespace LinkedInHelper;

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
        $@"Olá {nome}, muito obrigado por aceitar meu convite!

Atualmente atuo como desenvolvedor backend freelancer, com foco em C# e .NET.

Tenho buscado me conectar com profissionais de recrutamento para acompanhar oportunidades remotas, especialmente com escopo internacional.
        
Será um prazer manter contato e conversar sobre vagas alinhadas ao meu perfil.",

            "Convite Aceito - Recrutador Internacional" =>
$@"Hi {nome}, thank you for accepting my invitation!

I'm currently working as a freelance backend developer, focused on C# and .NET.

While I’ve been prioritizing remote roles, I’m also open to hybrid or on-site opportunities, depending on the project and how I can contribute.

If any position aligns with my profile, I’d love to explore it with you!",


            "Convite Aceito - Profissional Nacional" =>
        $@"Oi {nome}, obrigado por aceitar meu convite!

Hoje atuo como desenvolvedor backend freelancer, especializado em C# e .NET.

Estou sempre aberto a trocar ideias, aprender com colegas da área e fortalecer minha rede de contatos.

Vai ser ótimo compartilhar experiências e crescer juntos!",

            "Convite Aceito - Profissional Internacional" =>
        $@"Hi {nome}, thanks for connecting!

I'm currently working as a freelance backend developer, focused on C# and .NET.

I really value exchanging knowledge and staying connected with professionals in the field — looking forward to learning and growing together!",

            "Aceitando Convite - Recrutador Nacional" =>
        $@"Olá {nome}, obrigado pelo contato!

Atualmente atuo como desenvolvedor backend freelancer e estou em busca de oportunidades remotas com foco em .NET.

Gostaria de saber mais sobre as vagas que você está recrutando e ver se podemos alinhar uma conversa. Fico à disposição!",

            "Aceitando Convite - Recrutador Internacional" =>
            $@"Hi {nome}, thank you for reaching out!

I'm a backend developer specialized in .NET, currently working as a freelancer.

I’ve mainly pursued remote roles, but I'm now also open to hybrid and on-site opportunities — especially when I believe I can bring value to the team.

I’d be glad to hear more about the positions you're recruiting for!",

            "Aceitando Convite - Profissional Nacional" =>
        $@"Olá {nome}! Que bom poder me conectar com você por aqui. 😊

Hoje atuo como desenvolvedor backend freelancer, com foco em C# e .NET, e sigo me aprimorando continuamente, inclusive no inglês, buscando sempre evoluir como profissional.

É ótimo poder trocar experiências com colegas da área — toda dica, insight ou troca de ideia é muito bem-vinda. Fico à disposição para colaborar no que puder.

Um grande abraço e sucesso nos seus projetos!",

            "Aceitando Convite - Profissional Internacional" =>
        $@"Hi {nome}! I'm really glad to connect with you here on LinkedIn. 😊

I'm currently working as a freelance backend developer, specialized in C# and .NET, and I’m always looking to improve both technically and professionally.

It’s really valuable to exchange insights with fellow professionals — I’m always open to sharing and learning.

Wishing you success in your projects, and feel free to reach out anytime!",

            _ => "Tipo de mensagem não encontrado."
        };


        Clipboard.SetText(mensagem);
        textDone.Text = "Mensagem copiada:\n\n" + mensagem;
    }
}
