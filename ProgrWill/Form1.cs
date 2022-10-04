using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrWill
{
    public partial class ProgrWill : Form
    {
        public ProgrWill()
        {
            InitializeComponent();
        }

        private void btGenDoc_Click(object sender, EventArgs e)
        {
            ParamsContainer parsCntr = new ParamsContainer();
            parsCntr.sName = tbName.Text;
            parsCntr.sAltname = tbAltName.Text;
            parsCntr.sCounty = tbCounty.Text;
            parsCntr.sSpouse = tbSpouse.Text;

            for (int rows = 0; rows < dgChildren.Rows.Count - 1; rows++)
            {
                var child = new Child();
                child.sName = dgChildren.Rows[rows].Cells[0].Value.ToString();
                child.sDate = dgChildren.Rows[rows].Cells[1].Value.ToString();
                parsCntr.sChildren.Add(child);
            }

            parsCntr.sNameExclIndiv = tbNameExcIndiv.Text;
            parsCntr.sPersnRepr1 = tbPersRepr1.Text;
            parsCntr.sPersnRepr2 = tbPersRepr2.Text;
            parsCntr.sPersnRepr3 = tbPersRepr3.Text;
            parsCntr.bCremation = rbCremation.Checked;
            parsCntr.bBurial = rbBurial.Checked;
            parsCntr.sDate = dTmDate.Text;

            var docProcess = new DocProcessor();
            docProcess.ProcessDoc(parsCntr);
        }
    }
}
