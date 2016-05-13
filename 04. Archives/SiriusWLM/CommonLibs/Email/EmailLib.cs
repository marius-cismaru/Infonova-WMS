using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Net.Mime;

namespace Sirius.CommonLibs
{
    public class EmailLib
    {
        public static bool Send(string host, string port, string encryption, string address, string name, string username, string password, string toAddressList, string ccAddressList, string bccAddressList, string replyToAddressList, string subject, string body, List<string> attachmentFileList)
        {
            bool result = false;

            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            mail.From = new MailAddress(address, name);

            if ((toAddressList != null) && (toAddressList != string.Empty))
            {
                toAddressList = toAddressList.Replace(";", ",");
                string[] toAddressListArray = toAddressList.Split(',');
                foreach (var addr in toAddressListArray)
                {
                    if (addr.Trim() != string.Empty)
                    {
                        mail.To.Add(addr.Trim());
                    }
                }
            }

            if ((ccAddressList != null) && (ccAddressList != string.Empty))
            {
                ccAddressList = ccAddressList.Replace(";", ",");
                string[] ccAddressListArray = ccAddressList.Split(',');
                foreach (var addr in ccAddressListArray)
                {
                    if (addr.Trim() != string.Empty)
                    {
                        mail.CC.Add(addr.Trim());
                    }
                }
            }

            if ((replyToAddressList != null) && (replyToAddressList != string.Empty))
            {
                replyToAddressList = replyToAddressList.Replace(";", ",");
                string[] replyToAddressListArray = replyToAddressList.Split(',');
                foreach (var addr in replyToAddressListArray)
                {
                    if (addr.Trim() != string.Empty)
                    {
                        mail.ReplyToList.Add(addr.Trim());
                    }
                }
            }

            if ((bccAddressList != null) && (bccAddressList != string.Empty))
            {
                bccAddressList = bccAddressList.Replace(";", ",");
                string[] bccAddressListArray = bccAddressList.Split(',');
                foreach (var addr in bccAddressListArray)
                {
                    if (addr.Trim() != string.Empty)
                    {
                        mail.Bcc.Add(addr.Trim());
                    }
                }
            }

            mail.Subject = subject;
            //mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.Body = body;

            if ((attachmentFileList != null) && (attachmentFileList.Count > 0))
            {
                Attachment attachment;
                foreach (var file in attachmentFileList)
                {
                    if (File.Exists(file))
                    {
                        attachment = new Attachment(file, MediaTypeNames.Application.Octet);
                        attachment.NameEncoding = Encoding.UTF8;
                        attachment.TransferEncoding = TransferEncoding.Base64;
                        ContentDisposition disposition = attachment.ContentDisposition;
                        //disposition.CreationDate = File.GetCreationTime(file);
                        //disposition.ModificationDate = File.GetLastWriteTime(file);
                        //disposition.ReadDate = File.GetLastAccessTime(file);
                        disposition.FileName = Path.GetFileName(file);
                        disposition.Size = new FileInfo(file).Length;
                        disposition.DispositionType = DispositionTypeNames.Attachment;
                        mail.Attachments.Add(attachment);
                    }
                }
            }

            int portNumeric = 587;
            bool enableEncryption = false;
            int.TryParse(port, out portNumeric);
            if((encryption.ToUpper() == "SSL") || (encryption.ToUpper() == "TLS")) 
            {
                enableEncryption = true;
            }

            var smtp = new SmtpClient
            {
                Host = host,
                Port = portNumeric,
                EnableSsl = enableEncryption,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(username, password),
                Timeout = 20000
            };

            try
            {
                smtp.Send(mail);
                result = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Eroare trimitere email. Mai incearca o data in scurt timp.\n\n" + ex.ToString(), "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
    }
}
