using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Collections;
using System.Threading;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Pdf.IO;
using System.Runtime.CompilerServices;

namespace AutoComposingMailer
{
    //Customizable
    enum Company {COMPANY0, COMPANY1};
    static class Program
    {
        const string ESCAPE = "\"";
        public static string REPO_DIR = "", SENT_DIR = "", LOG_DIR="", MAIL_SERVER = "", SERVER_PORT = "", USER = "", PASSWORD = "", COMPANY0_LOGO="", COMPANY1_LOGO="", NAME="", DEPARTMENT="";
        public static bool SSL = false;
        public static FormFolders formFolders;
        public static FormLog formLog;
        public static FormSMTP formSMTP;
        public static FormClientsList formClientsList;
        public static FormImages formImages;
        public static FormAttachmentsList formAttachmentsList;
        public static FormStart formStart;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formFolders = new FormFolders();
            formLog = new FormLog();
            formSMTP = new FormSMTP();
            formClientsList = new FormClientsList();
            formImages = new FormImages();
            formAttachmentsList = new FormAttachmentsList();
            formStart = new FormStart();
            if (!File.Exists(Application.StartupPath + "/config.conf"))
            {
                UpdateConfig();
            }
            else
            {
                ReadConfig();

            }
            Application.Run(formStart);
        }
        public static void UpdateConfig()
        {
            string[] createText = { "REPO_DIR=" + REPO_DIR, "SENT_DIR=" + SENT_DIR, "LOG_DIR=" + LOG_DIR, "MAIL_SERVER=" + MAIL_SERVER, "SERVER_PORT=" + SERVER_PORT, "SSL="+SSL.ToString(), "USER=" + USER, "PASSWORD="+PASSWORD, "NAME=" + NAME, "DEPARTMENT=" + DEPARTMENT, "COMPANY0_LOGO=" + COMPANY0_LOGO, "COMPANY1_LOGO=" + COMPANY1_LOGO};
            File.WriteAllLines(Application.StartupPath + "/config.conf", createText);
        }
        public static void ReadConfig()
        {
            string[] readText = File.ReadAllLines(Application.StartupPath + "/config.conf");
            if (readText.Length <1 || readText[0].Split('=').Length != 2)
            {
                REPO_DIR = "";
            }
            else
            {
                REPO_DIR = readText[0].Split('=')[1];

            }
            formFolders.textBoxRepo.Text = REPO_DIR;

            if (readText.Length <2 || readText[1].Split('=').Length != 2)
            {
                SENT_DIR = "";
            }
            else
            {
                SENT_DIR = readText[1].Split('=')[1];

            }
            formFolders.textBoxSent.Text = SENT_DIR;

            if (readText.Length <3 || readText[2].Split('=').Length != 2)
            {
                LOG_DIR = "";
            }
            else
            {
                LOG_DIR = readText[2].Split('=')[1];

            }
            formFolders.textBoxLog.Text = LOG_DIR;
            if (readText.Length <4 || readText[3].Split('=').Length != 2)
            {
                MAIL_SERVER = "";
            }
            else
            {
                MAIL_SERVER = readText[3].Split('=')[1];
            }
            formSMTP.textBoxMailServer.Text = MAIL_SERVER;
            if (readText.Length <5 || readText[4].Split('=').Length != 2)
            {
                SERVER_PORT = "";
            }
            else
            {
                SERVER_PORT = readText[4].Split('=')[1];
            }
            formSMTP.textBoxPort.Text = SERVER_PORT;
            if (readText.Length <6 || readText[5].Split('=').Length != 2)
            {
                SSL = false;
            }
            else
            {
                if (readText.Length <6 || readText[5].Split('=')[1] == "True")
                {
                    SSL = true;
                }
                else
                {
                    SSL = false;
                }
            }
            formSMTP.checkBoxSSL.Checked = SSL;
            if (readText.Length <7 || readText[6].Split('=').Length != 2)
            {
                USER = "";
            }
            else
            {
                USER = readText[6].Split('=')[1];
            }
            formSMTP.textBoxUser.Text = USER;
            if (readText.Length <8 || readText[7].Split('=').Length != 2)
            {
                PASSWORD = "";
            }
            else
            {
                PASSWORD = readText[7].Split('=')[1];
            }
            formSMTP.textBoxPassword.Text = PASSWORD;
            if(readText.Length <9 || readText[8].Split('=').Length != 2)
            {
                NAME = "";
            }
            else
            {
                NAME = readText[8].Split('=')[1];
            }
            formSMTP.textBoxNameSign.Text = NAME;
            if (readText.Length <10 || readText[9].Split('=').Length != 2)
            {
                DEPARTMENT = "";
            }
            else
            {
                DEPARTMENT = readText[9].Split('=')[1];
            }
            formSMTP.textBoxDepartment.Text = DEPARTMENT;
            if (readText.Length < 11 || readText[10].Split('=').Length != 2)
            {
                COMPANY0_LOGO = "";
            }
            else
            {
                COMPANY0_LOGO = readText[10].Split('=')[1];
            }
            formImages.textBoxImgCompany0.Text = COMPANY0_LOGO;
            if (readText.Length < 12 || readText[11].Split('=').Length != 2)
            {
                COMPANY1_LOGO = "";
            }
            else
            {
                COMPANY1_LOGO = readText[11].Split('=')[1];
            }
            formImages.textBoxImgCompany1.Text = COMPANY1_LOGO;
        }
        public static void SendFiles()
        {
            string[] clientsDir = Directory.GetDirectories(REPO_DIR);
            if (clientsDir.Length != 0)
            {
                int percentage = 100 / (clientsDir.Length * 2);
                formStart.progressBarScan.Step = percentage;
            }
            foreach (string dir in clientsDir)
            {
                string email = "";
                ArrayList[] attachments = new ArrayList[2] { new ArrayList(), new ArrayList() };
                ArrayList[] filesToMove = new ArrayList[2] { new ArrayList(), new ArrayList() };
                ArrayList[] filesToClose = new ArrayList[2] { new ArrayList(), new ArrayList() };
                string[] files = Directory.GetFileSystemEntries(dir);

                foreach (string file in files)
                {
                    if (file.Contains("email.txt"))
                    {
                        email = File.ReadAllLines(file)[0];
                    }
                    if (file.EndsWith(((Company)0).ToString()))
                    {
                        foreach (string attachment in Directory.GetFiles(file))
                        {
                            attachments[0].Add(PrepareAttachment(attachment, (Company)0, filesToClose[0]));
                            filesToMove[0].Add(attachment);
                        }
                    }
                    if (file.EndsWith(((Company)1).ToString()))
                    {
                        foreach (string attachment in Directory.GetFiles(file))
                        {
                            attachments[1].Add(PrepareAttachment(attachment, (Company)1, filesToClose[1]));
                            filesToMove[1].Add(attachment);
                        }
                    }
                }
                if (email != "" && attachments[0].Count> 0)
                {
                    if (SendMessage(email, attachments[0]))
                    {
                        WriteLogAndCloseFiles(email, filesToMove[0], filesToClose[0]);
                    }
                }
                formStart.progressBarScan.PerformStep();
                if (email != "" && attachments[1].Count> 0)
                {
                    if (SendMessage(email, attachments[1]))
                    {
                        WriteLogAndCloseFiles(email, filesToMove[1], filesToClose[1]);
                    }
                }
                formStart.progressBarScan.PerformStep();
            }
        }
        public static void ScanFiles()
        {
            string[] clientsDir = Directory.GetDirectories(REPO_DIR);
            Program.formAttachmentsList.treeViewAttachments.Nodes.Clear();
            foreach (string dir in clientsDir)
            {
                string email = "";
                ArrayList[] attachments = new ArrayList[2] { new ArrayList(), new ArrayList() };
                string[] files = Directory.GetFileSystemEntries(dir);
                TreeNode client = new TreeNode(Path.GetFileName(dir));
                foreach (string file in files)
                {
                    if (file.Contains("email.txt"))
                    {
                        email = File.ReadAllLines(file)[0];
                        client.Text += " (" + email + ")";
                    }
                    if (file.EndsWith(((Company)0).ToString()))
                    {
                        TreeNode company0 = null;
                        foreach (string attachment in Directory.GetFiles(file))
                        {
                            if (attachment.EndsWith(".pdf"))
                            {
                                if (company0 == null)
                                {
                                    company0 = new TreeNode(Enum.GetName(typeof(Company), 0));
                                }
                                TreeNode attachmentNode = new TreeNode(Path.GetFileName(attachment));
                                company0.Nodes.Add(attachmentNode);
                            }
                        }
                        if(company0 != null) {
                            client.Nodes.Add(company0);
                        }
                    }
                    if (file.EndsWith(((Company)1).ToString()))
                    {
                        TreeNode company1 = null;
                        foreach (string attachment in Directory.GetFiles(file))
                        {
                            if (attachment.EndsWith(".pdf"))
                            {
                                if (company1 == null)
                                {
                                    company1 = new TreeNode(Enum.GetName(typeof(Company), 1));
                                }
                                TreeNode attachmentNode = new TreeNode(Path.GetFileName(attachment));
                                company1.Nodes.Add(attachmentNode);
                            }
                            if (company1 != null)
                            {
                                client.Nodes.Add(company1);
                            }
                        }
                    }
                }
                if(client.Nodes.Count != 0)
                {
                    Program.formAttachmentsList.treeViewAttachments.Nodes.Add(client);
                }
            }
        }
        public static MimePart PrepareAttachment(string attachment, Company company, ArrayList filesToClose)
        {
            Boolean printedLogo = false;
            string backupPath = SENT_DIR + "\\" + Path.GetFileName(Path.GetDirectoryName(Path.GetDirectoryName(attachment))) + "\\" + Path.GetFileName(Path.GetDirectoryName(attachment)) + "\\"  + "\\BACKUP";
            if (!Directory.Exists(backupPath))
            {
                Directory.CreateDirectory(backupPath);
            }
            if (!File.Exists(backupPath + "\\" + Path.GetFileName(attachment))) File.Copy(attachment, backupPath + "\\" + Path.GetFileName(attachment));
            if(company == (Company)0)
            {
                GeneratePDF(attachment, COMPANY0_LOGO);
                printedLogo = true;
            }
            if(company == (Company)1)
            {
                GeneratePDF(attachment, COMPANY1_LOGO);
                printedLogo = true;
            }
            if(printedLogo == true)
            {
                FileStream file;
                file = File.OpenRead(attachment);
                MimePart attachmentFinal = new MimePart("application", "pdf")
                {
                    Content = new MimeContent(file),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(attachment)
                };
                filesToClose.Add(file);
                return attachmentFinal;
            }
            else
            {
                throw new Exception();
            }
        }
        public static void WriteLogAndCloseFiles(string email, ArrayList filesToMove, ArrayList filesToClose)
        {
            File.AppendAllText(LOG_DIR + "\\log.txt", DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "Mail sent correctly to " + email + " with the attachments");
            int times = 0;
            foreach (string file in filesToMove)
            {
                if (times != 0)
                {
                    File.AppendAllText(LOG_DIR + "\\log.txt", ",");
                }
                File.AppendAllText(LOG_DIR + "\\log.txt", " " + Path.GetFileName(file));
                times += 1;
            }
            File.AppendAllText(LOG_DIR + "\\log.txt", "\n");
            foreach (FileStream file in filesToClose)
            {
                file.Close();
            }
            foreach (string file in filesToMove)
            {
                string destinationPath = SENT_DIR + "\\" + Path.GetFileName(Path.GetDirectoryName(Path.GetDirectoryName(file))) + "\\" + Path.GetFileName(Path.GetDirectoryName(file)) + "\\SENT\\" + Path.GetFileName(file);                
                Directory.CreateDirectory(SENT_DIR + "\\" + Path.GetFileName(Path.GetDirectoryName(Path.GetDirectoryName(file))) + "\\" + Path.GetFileName(Path.GetDirectoryName(file)) + "\\SENT");
                if (!File.Exists(destinationPath))
                {
                    File.Copy(file, destinationPath);
                }
                else
                {
                    File.Delete(destinationPath);
                    File.Copy(file, destinationPath);
                }
                try
                {
                    File.Delete(file);
                }
                catch (Exception)
                {
                    if (!File.Exists(LOG_DIR))
                    {
                        Directory.CreateDirectory(LOG_DIR);
                    }
                    if (!File.Exists(LOG_DIR + "\\deletefiles.txt"))
                    {
                        File.WriteAllText(LOG_DIR + "\\deletefiles.txt", file);
                    }
                    else
                    {
                        File.AppendAllText(LOG_DIR + "\\deletefiles.txt", "\n" + file);
                    }
                }
            }
        }
        //Customizable
        public static bool SendMessage(string email, ArrayList attachments)
        {
            SmtpClient client = new SmtpClient();
            try
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("Invoices", USER));
                message.To.Add(new MailboxAddress(email, email));
                message.Subject = "Invoices " + DateTime.Now.ToString("dd-MM-yy");
                message.Headers[HeaderId.DispositionNotificationTo] = USER;
                var body = new TextPart("html")
                {
                    Text = @"These are the invoices, sent to you by " + NAME + "at " + DEPARTMENT + " Department"
                };
                Multipart multipart = new Multipart("mixed")
                {
                    body
                };
                foreach (MimePart attachment in attachments)
                {
                    multipart.Add(attachment);
                }
                message.Body = multipart;
                client.Connect(MAIL_SERVER, Int32.Parse(SERVER_PORT), SSL);
                client.Authenticate(USER, PASSWORD);
                client.Send(message);
                client.Disconnect(true);
                return true;
            }
            catch (Exception)
            {
                if (client.IsConnected) { client.Disconnect(true); }
                File.AppendAllText(LOG_DIR + "\\log.txt", DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " The mail was not sent to " + email + " with the attachments");
                int times = 0;
                foreach (MimePart attachment in attachments)
                {
                    if (times != 0)
                    {
                        File.AppendAllText(LOG_DIR + "\\log.txt", ",");
                    }
                    File.AppendAllText(LOG_DIR + "\\log.txt", " " + attachment.FileName);
                    times += 1;
                }
                File.AppendAllText(LOG_DIR + "\\log.txt", "\n");
                return false;
            }
        }
        public static void GeneratePDF(string filename, string imageLoc)
        {
            PdfDocument document = PdfReader.Open(filename);
            for (int i = 0; i <document.PageCount; i++)
            {
                if (i % 2 == 0)
                {
                    PdfPage page = document.Pages[i];
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, imageLoc, 0, 0, 600, 850);
                }
            }
            document.Save(filename);
            document.Close();
        }
        public static void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
        {
            XImage image = XImage.FromFile(jpegSamplePath);
            gfx.DrawImage(image, x, y, width, height);
        }
        public static void CreateClientFolder(string name, string email)
        {
            if (!Directory.Exists(REPO_DIR + "\\"+name)){
                Directory.CreateDirectory(REPO_DIR + "\\" + name + "\\" + ((Company)0).ToString());
                Directory.CreateDirectory(REPO_DIR + "\\" + name + "\\" + ((Company)1).ToString());
            }
            File.WriteAllText(REPO_DIR + "\\" + name + "\\email.txt", email);
        }
        public static void ReadClients()
        {
            string[] directoriosClientes = Directory.GetDirectories(REPO_DIR);
            formClientsList.listBoxClients.Items.Clear();
            foreach (string directorio in directoriosClientes)
            {
                string email = File.ReadAllText(directorio + "\\email.txt");
                formClientsList.listBoxClients.Items.Add(Path.GetFileName(directorio) + " (" + email + ")");
            }
        }
        public static void CreateMassiveClients(string path)
        {
            if (File.Exists(path))
            {
                string[] contacts = File.ReadAllLines(path);
                foreach(string contact in contacts)
                {
                    try
                    {
                        string[] words = contact.Split(';');
                        if (words.Length == 2)
                        {
                            CreateClientFolder(words[0], words[1]);
                        }
                    }catch(Exception)
                    {

                    }
                }
            }
        }
    }
}
