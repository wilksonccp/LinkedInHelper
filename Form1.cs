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
            // Recrutadores
            "Convite Aceito - Recrutador Nacional" =>
$@"Olá {nome}, obrigado por aceitar meu convite!

Atuo como desenvolvedor backend com foco em C# e .NET. Sou um business-driven developer — minha experiência anterior em gestão de negócios me permite alinhar soluções técnicas aos objetivos estratégicos das empresas.

Atualmente trabalho como freelancer, mas estou aberto a oportunidades formais onde minhas habilidades possam gerar impacto — seja no backend puro ou em projetos que combinem tecnologia e visão de negócios.

Conhece alguma oportunidade onde eu possa contribuir? Será um prazer ajudar sua equipe!",

            "Convite Aceito - Recrutador Internacional" =>
$@"Hi {nome}, thank you for accepting my invitation!

I’m a backend developer focused on C# and .NET — a business-driven developer, using my background in business management to deliver solutions aligned with real business goals.

Currently working as a freelancer, I’m open to full-time or project-based roles where I can contribute — either in purely technical positions or in projects that benefit from my strategic perspective.

Do you know of any opportunity where I could contribute? I’d be glad to help your team!",

            "Aceitando Convite - Recrutador Nacional" =>
$@"Olá {nome}, obrigado pelo contato!

Sou desenvolvedor backend com foco em C# e .NET, atuando como freelancer. Me considero um business-driven developer — minha formação em administração me permite unir soluções técnicas a objetivos estratégicos das empresas.

Estou aberto a oportunidades onde minhas habilidades possam gerar valor, seja em backend puro ou em projetos que combinem tecnologia e visão de negócios.

Conhece alguma oportunidade onde eu possa contribuir? Será um prazer ajudar sua equipe!",

            "Aceitando Convite - Recrutador Internacional" =>
$@"Hi {nome}, thank you for reaching out!

I’m a backend developer specialized in C# and .NET, currently working as a freelancer. I consider myself a business-driven developer, using my background in business management to align technical solutions with business needs.

I’m open to both full-time and project-based roles, where my skills can help create real impact — whether purely technical or involving strategic collaboration.

Do you know of any opportunity where I could contribute? I’d be glad to help your team!",

            // Profissionais
            "Convite Aceito - Profissional Nacional" =>
$@"Olá {nome}, obrigado por aceitar meu convite!

Atuo como desenvolvedor backend especializado em C# e .NET. Me considero um business-driven developer, pois minha formação anterior em administração me permite olhar a tecnologia como ferramenta estratégica para gerar resultados.

Admiro conexões que vão além do código — acredito que compartilhar experiências e ideias nos ajuda a crescer juntos.

Vamos manter contato!",

            "Convite Aceito - Profissional Internacional" =>
$@"Hi {nome}, thanks for connecting!

I’m a backend developer focused on C# and .NET — a business-driven developer, using my background in business management to deliver solutions that make sense for real-world businesses.

I believe that meaningful connections go beyond code — sharing ideas and experiences helps us grow together.

Let’s keep in touch!",

            "Aceitando Convite - Profissional Nacional" =>
$@"Olá {nome}! Que bom receber seu convite.

Sou desenvolvedor backend especializado em C# e .NET. Me considero um business-driven developer, unindo minha experiência anterior em administração à tecnologia, sempre buscando soluções que gerem valor real para os negócios.

Acredito muito na troca entre profissionais como caminho para crescimento — tanto técnico quanto estratégico.

Vamos seguir conectados!",

            "Aceitando Convite - Profissional Internacional" =>
$@"Hi {nome}! Glad to receive your connection request.

I’m a backend developer specialized in C# and .NET — a business-driven developer, combining my background in business management with technology to create real-world, value-driven solutions.

I truly believe that sharing insights with fellow professionals helps us grow — technically and strategically.

Let’s stay connected!",

            _ => "Tipo de mensagem não encontrado."
        };

        Clipboard.SetText(mensagem);
        textDone.Text = "Mensagem copiada:\n\n" + mensagem;
    }
}
