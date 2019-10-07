using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace AssinaturaLocal
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnAssinar_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(txtCNPJCert.Text.Trim()) || "".Equals(rtxtXmlAssinar.Text.Trim()) || "".Equals(txtTag.Text.Trim()))
                {
                    MessageBox.Show("CNPJ do certificado, Tag e Xml para Assinar devem ser preenchidos");
                    return;
                }
                Certificados buscaCert = new Certificados();
                X509Certificate2 cert = buscaCert.buscaCertificado(txtCNPJCert.Text.Trim());

                if (cert == null)
                {
                    MessageBox.Show("Certificado Digital não encontrado");
                    return;
                }

                String tag = txtTag.Text.Trim();
                String xmlParaAssinar = rtxtXmlAssinar.Text.Trim();
                String xmlAssinado;
                
                xmlAssinado = assinaXML(xmlParaAssinar, cert, tag);

                rtxtXmlAssinado.Text = xmlAssinado;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private String assinaXML(String xml, X509Certificate2 cert, String refURI)
        {
            AssinaturaDigital AD = new AssinaturaDigital();

            int resultado = AD.Assinar(xml, refURI, cert);
            if(resultado != 0)
            {
                throw new Exception(AD.mensagemResultado);
            }

            return AD.XMLStringAssinado;
        }
    }
}
