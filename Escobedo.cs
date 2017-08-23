using System;
using System.Windows.Forms;
using System.Windows.Forms;
namespace entendiendoForms    
{        
public partial class Escobedo : Form        {
            
public Escobedo()            {                
 private Label labEstado;
           
           InitializeComponent();
            }
            private void InitializeComponent()
           {
                this.SuspendLayout();
this.labEstado = new Label();this.labEstado.Location = new System.Drawing.Point(27, 36);this.labEstado.Name = "labEstado"; 

this.Controls.Add(this.labEstado);
                //                 
               // Escobedo               
                // 
                this.ClientSize = new System.Drawing.Size(284, 562);
                this.Name = "Escobedo";
                this.Text = "Escobedo";
                this.ResumeLayout(false);
            }
        }
    }