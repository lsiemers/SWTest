namespace SWTest

{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            this->button1 = gcnew System::Windows::Forms::Button();
            this->SuspendLayout();

            // button1
            this->button1->Location = System::Drawing::Point(100, 100);
            this->button1->Name = L"button1";
            this->button1->Size = System::Drawing::Size(75, 23);
            this->button1->Text = L"Click Me";
            this->button1->Click += gcnew System::EventHandler(this, &Form1::button1_Click);

            // Form1
            this->ClientSize = System::Drawing::Size(284, 261);
            this->Controls->Add(this->button1);
            this->Name = L"Form1";
            this->Text = L"Windows Forms App";
            this->ResumeLayout(false);
        }

        #endregion
    }
}

