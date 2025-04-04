namespace LinkedInHelper;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        cmbTipoResposta = new ComboBox();
        txtNomePessoa = new TextBox();
        btnGerarCopiar = new Button();
        label1 = new Label();
        LabelInsert = new Label();
        LabelPosition = new Label();
        textDone = new TextBox();
        SuspendLayout();
        // 
        // cmbTipoResposta
        // 
        cmbTipoResposta.FormattingEnabled = true;
        cmbTipoResposta.Location = new Point(171, 80);
        cmbTipoResposta.Name = "cmbTipoResposta";
        cmbTipoResposta.Size = new Size(281, 23);
        cmbTipoResposta.TabIndex = 0;
        // 
        // txtNomePessoa
        // 
        txtNomePessoa.Location = new Point(12, 80);
        txtNomePessoa.Name = "txtNomePessoa";
        txtNomePessoa.Size = new Size(137, 23);
        txtNomePessoa.TabIndex = 1;
        // 
        // btnGerarCopiar
        // 
        btnGerarCopiar.Location = new Point(12, 118);
        btnGerarCopiar.Name = "btnGerarCopiar";
        btnGerarCopiar.Size = new Size(125, 23);
        btnGerarCopiar.TabIndex = 2;
        btnGerarCopiar.Text = "Gerar e Copiar";
        btnGerarCopiar.UseVisualStyleBackColor = true;
        btnGerarCopiar.Click += btnGerarCopiar_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial", 25F);
        label1.Location = new Point(119, 9);
        label1.Name = "label1";
        label1.Size = new Size(249, 39);
        label1.TabIndex = 4;
        label1.Text = "LinkedIn Helper";
        label1.Click += label1_Click_1;
        // 
        // LabelInsert
        // 
        LabelInsert.AutoSize = true;
        LabelInsert.Location = new Point(12, 62);
        LabelInsert.Name = "LabelInsert";
        LabelInsert.Size = new Size(137, 15);
        LabelInsert.TabIndex = 5;
        LabelInsert.Text = "Insira o nome da pessoa:";
        // 
        // LabelPosition
        // 
        LabelPosition.AutoSize = true;
        LabelPosition.Location = new Point(171, 62);
        LabelPosition.Name = "LabelPosition";
        LabelPosition.Size = new Size(154, 15);
        LabelPosition.TabIndex = 6;
        LabelPosition.Text = "Selecione o tipo de resposta";
        // 
        // textDone
        // 
        textDone.Location = new Point(12, 159);
        textDone.Multiline = true;
        textDone.Name = "textDone";
        textDone.Size = new Size(432, 200);
        textDone.TabIndex = 7;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(484, 398);
        Controls.Add(textDone);
        Controls.Add(LabelPosition);
        Controls.Add(LabelInsert);
        Controls.Add(label1);
        Controls.Add(btnGerarCopiar);
        Controls.Add(txtNomePessoa);
        Controls.Add(cmbTipoResposta);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox cmbTipoResposta;
    private TextBox txtNomePessoa;
    private Button btnGerarCopiar;
    private Label label1;
    private Label LabelInsert;
    private Label LabelPosition;
    private TextBox textDone;
}
