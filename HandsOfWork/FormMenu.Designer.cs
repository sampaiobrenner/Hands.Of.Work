
namespace HandsOfWork
{
    partial class FormMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCategoriaDeProduto = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCategoriaDeProduto
            // 
            this.btnCategoriaDeProduto.Location = new System.Drawing.Point(286, 30);
            this.btnCategoriaDeProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategoriaDeProduto.Name = "btnCategoriaDeProduto";
            this.btnCategoriaDeProduto.Size = new System.Drawing.Size(253, 82);
            this.btnCategoriaDeProduto.TabIndex = 2;
            this.btnCategoriaDeProduto.TabStop = false;
            this.btnCategoriaDeProduto.Text = "Categoria de produtos";
            this.btnCategoriaDeProduto.UseVisualStyleBackColor = true;
            this.btnCategoriaDeProduto.Click += new System.EventHandler(this.btnCategoriaDeProduto_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(25, 30);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(253, 82);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.TabStop = false;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(25, 120);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(253, 82);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.TabStop = false;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Controle da transportadora";
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(286, 120);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(253, 82);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.TabStop = false;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnProdutos);
            this.panel1.Controls.Add(this.btnPedidos);
            this.panel1.Controls.Add(this.btnCategoriaDeProduto);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Location = new System.Drawing.Point(44, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 232);
            this.panel1.TabIndex = 5;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 409);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategoriaDeProduto;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Panel panel1;
    }
}

