namespace MemoriasDinamicas.FE
{
    partial class MemoriaDinamicaForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuTabs = new System.Windows.Forms.TabControl();
            this.QueueTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaInputsCola = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btIngresarEnCola = new System.Windows.Forms.Button();
            this.tbxInput1 = new System.Windows.Forms.TextBox();
            this.StackTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaInputsPila = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btIngresarEnPila = new System.Windows.Forms.Button();
            this.tbxInput2 = new System.Windows.Forms.TextBox();
            this.ArrayListTab = new System.Windows.Forms.TabPage();
            this.IngresarIndice = new System.Windows.Forms.GroupBox();
            this.btIngresarIndice = new System.Windows.Forms.Button();
            this.tbxInput3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btIngresarEnArrayList = new System.Windows.Forms.Button();
            this.tbxResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxIndice = new System.Windows.Forms.TextBox();
            this.MenuTabs.SuspendLayout();
            this.QueueTab.SuspendLayout();
            this.StackTab.SuspendLayout();
            this.ArrayListTab.SuspendLayout();
            this.IngresarIndice.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTabs
            // 
            this.MenuTabs.Controls.Add(this.QueueTab);
            this.MenuTabs.Controls.Add(this.StackTab);
            this.MenuTabs.Controls.Add(this.ArrayListTab);
            this.MenuTabs.Location = new System.Drawing.Point(116, 34);
            this.MenuTabs.Name = "MenuTabs";
            this.MenuTabs.SelectedIndex = 0;
            this.MenuTabs.Size = new System.Drawing.Size(534, 299);
            this.MenuTabs.TabIndex = 1;
            // 
            // QueueTab
            // 
            this.QueueTab.Controls.Add(this.label1);
            this.QueueTab.Controls.Add(this.ListaInputsCola);
            this.QueueTab.Controls.Add(this.btIngresarEnCola);
            this.QueueTab.Controls.Add(this.tbxInput1);
            this.QueueTab.Location = new System.Drawing.Point(4, 22);
            this.QueueTab.Name = "QueueTab";
            this.QueueTab.Padding = new System.Windows.Forms.Padding(3);
            this.QueueTab.Size = new System.Drawing.Size(526, 273);
            this.QueueTab.TabIndex = 0;
            this.QueueTab.Text = "Queue";
            this.QueueTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Queue";
            // 
            // ListaInputsCola
            // 
            this.ListaInputsCola.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ListaInputsCola.HideSelection = false;
            this.ListaInputsCola.Location = new System.Drawing.Point(228, 51);
            this.ListaInputsCola.Name = "ListaInputsCola";
            this.ListaInputsCola.Size = new System.Drawing.Size(271, 178);
            this.ListaInputsCola.TabIndex = 2;
            this.ListaInputsCola.UseCompatibleStateImageBehavior = false;
            this.ListaInputsCola.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lista";
            // 
            // btIngresarEnCola
            // 
            this.btIngresarEnCola.Location = new System.Drawing.Point(20, 77);
            this.btIngresarEnCola.Name = "btIngresarEnCola";
            this.btIngresarEnCola.Size = new System.Drawing.Size(75, 23);
            this.btIngresarEnCola.TabIndex = 1;
            this.btIngresarEnCola.Text = "Ingresar";
            this.btIngresarEnCola.UseVisualStyleBackColor = true;
            this.btIngresarEnCola.Click += new System.EventHandler(this.btIngresarEnCola_Click);
            // 
            // tbxInput1
            // 
            this.tbxInput1.Location = new System.Drawing.Point(20, 51);
            this.tbxInput1.Name = "tbxInput1";
            this.tbxInput1.Size = new System.Drawing.Size(100, 20);
            this.tbxInput1.TabIndex = 0;
            // 
            // StackTab
            // 
            this.StackTab.Controls.Add(this.label2);
            this.StackTab.Controls.Add(this.ListaInputsPila);
            this.StackTab.Controls.Add(this.btIngresarEnPila);
            this.StackTab.Controls.Add(this.tbxInput2);
            this.StackTab.Location = new System.Drawing.Point(4, 22);
            this.StackTab.Name = "StackTab";
            this.StackTab.Padding = new System.Windows.Forms.Padding(3);
            this.StackTab.Size = new System.Drawing.Size(526, 273);
            this.StackTab.TabIndex = 1;
            this.StackTab.Text = "Stack";
            this.StackTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stack";
            // 
            // ListaInputsPila
            // 
            this.ListaInputsPila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.ListaInputsPila.HideSelection = false;
            this.ListaInputsPila.Location = new System.Drawing.Point(229, 52);
            this.ListaInputsPila.Name = "ListaInputsPila";
            this.ListaInputsPila.Size = new System.Drawing.Size(271, 178);
            this.ListaInputsPila.TabIndex = 6;
            this.ListaInputsPila.UseCompatibleStateImageBehavior = false;
            this.ListaInputsPila.View = System.Windows.Forms.View.List;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lista";
            // 
            // btIngresarEnPila
            // 
            this.btIngresarEnPila.Location = new System.Drawing.Point(21, 78);
            this.btIngresarEnPila.Name = "btIngresarEnPila";
            this.btIngresarEnPila.Size = new System.Drawing.Size(75, 23);
            this.btIngresarEnPila.TabIndex = 5;
            this.btIngresarEnPila.Text = "Ingresar";
            this.btIngresarEnPila.UseVisualStyleBackColor = true;
            this.btIngresarEnPila.Click += new System.EventHandler(this.btIngresarEnPila_Click);
            // 
            // tbxInput2
            // 
            this.tbxInput2.Location = new System.Drawing.Point(21, 52);
            this.tbxInput2.Name = "tbxInput2";
            this.tbxInput2.Size = new System.Drawing.Size(100, 20);
            this.tbxInput2.TabIndex = 4;
            // 
            // ArrayListTab
            // 
            this.ArrayListTab.Controls.Add(this.label4);
            this.ArrayListTab.Controls.Add(this.tbxResultado);
            this.ArrayListTab.Controls.Add(this.tbxInput3);
            this.ArrayListTab.Controls.Add(this.IngresarIndice);
            this.ArrayListTab.Controls.Add(this.label3);
            this.ArrayListTab.Controls.Add(this.btIngresarEnArrayList);
            this.ArrayListTab.Location = new System.Drawing.Point(4, 22);
            this.ArrayListTab.Name = "ArrayListTab";
            this.ArrayListTab.Padding = new System.Windows.Forms.Padding(3);
            this.ArrayListTab.Size = new System.Drawing.Size(526, 273);
            this.ArrayListTab.TabIndex = 2;
            this.ArrayListTab.Text = "Array List";
            this.ArrayListTab.UseVisualStyleBackColor = true;
            // 
            // IngresarIndice
            // 
            this.IngresarIndice.Controls.Add(this.tbxIndice);
            this.IngresarIndice.Controls.Add(this.label5);
            this.IngresarIndice.Controls.Add(this.btIngresarIndice);
            this.IngresarIndice.Location = new System.Drawing.Point(135, 154);
            this.IngresarIndice.Name = "IngresarIndice";
            this.IngresarIndice.Size = new System.Drawing.Size(258, 86);
            this.IngresarIndice.TabIndex = 12;
            this.IngresarIndice.TabStop = false;
            // 
            // btIngresarIndice
            // 
            this.btIngresarIndice.Location = new System.Drawing.Point(92, 55);
            this.btIngresarIndice.Name = "btIngresarIndice";
            this.btIngresarIndice.Size = new System.Drawing.Size(75, 23);
            this.btIngresarIndice.TabIndex = 11;
            this.btIngresarIndice.Text = "Ingresar";
            this.btIngresarIndice.UseVisualStyleBackColor = true;
            this.btIngresarIndice.Click += new System.EventHandler(this.btIngresarIndice_Click);
            // 
            // tbxInput3
            // 
            this.tbxInput3.Location = new System.Drawing.Point(43, 54);
            this.tbxInput3.Name = "tbxInput3";
            this.tbxInput3.Size = new System.Drawing.Size(100, 20);
            this.tbxInput3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Array List";
            // 
            // btIngresarEnArrayList
            // 
            this.btIngresarEnArrayList.Location = new System.Drawing.Point(43, 80);
            this.btIngresarEnArrayList.Name = "btIngresarEnArrayList";
            this.btIngresarEnArrayList.Size = new System.Drawing.Size(75, 23);
            this.btIngresarEnArrayList.TabIndex = 9;
            this.btIngresarEnArrayList.Text = "Ingresar";
            this.btIngresarEnArrayList.UseVisualStyleBackColor = true;
            this.btIngresarEnArrayList.Click += new System.EventHandler(this.btIngresarEnArrayList_Click);
            // 
            // tbxResultado
            // 
            this.tbxResultado.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxResultado.Location = new System.Drawing.Point(298, 74);
            this.tbxResultado.Name = "tbxResultado";
            this.tbxResultado.ReadOnly = true;
            this.tbxResultado.Size = new System.Drawing.Size(201, 29);
            this.tbxResultado.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ingrese la posicion del objeto que desea leer";
            // 
            // tbxIndice
            // 
            this.tbxIndice.Location = new System.Drawing.Point(79, 33);
            this.tbxIndice.Name = "tbxIndice";
            this.tbxIndice.Size = new System.Drawing.Size(100, 20);
            this.tbxIndice.TabIndex = 13;
            this.tbxIndice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxIndice_KeyPress);
            // 
            // MemoriaDinamicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuTabs);
            this.Name = "MemoriaDinamicaForm";
            this.Text = "Form1";
            this.MenuTabs.ResumeLayout(false);
            this.QueueTab.ResumeLayout(false);
            this.QueueTab.PerformLayout();
            this.StackTab.ResumeLayout(false);
            this.StackTab.PerformLayout();
            this.ArrayListTab.ResumeLayout(false);
            this.ArrayListTab.PerformLayout();
            this.IngresarIndice.ResumeLayout(false);
            this.IngresarIndice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MenuTabs;
        private System.Windows.Forms.TabPage QueueTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListaInputsCola;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btIngresarEnCola;
        private System.Windows.Forms.TextBox tbxInput1;
        private System.Windows.Forms.TabPage StackTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ListaInputsPila;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btIngresarEnPila;
        private System.Windows.Forms.TextBox tbxInput2;
        private System.Windows.Forms.TabPage ArrayListTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btIngresarEnArrayList;
        private System.Windows.Forms.GroupBox IngresarIndice;
        private System.Windows.Forms.Button btIngresarIndice;
        private System.Windows.Forms.TextBox tbxInput3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxIndice;
    }
}

