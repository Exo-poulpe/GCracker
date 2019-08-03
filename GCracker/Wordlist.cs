using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GCracker
{
    class Wordlist : BaseAttackor, IAttackor
    {
        private string _path;


        private uint _lineNumber;

        public uint LineNumber
        {
            get
            {
                return _lineNumber;
            }
            set
            {
                _lineNumber = value;
            }
        }
               

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        static StringBuilder tmp;
        string curPass = "";
        static uint count = 0;
        double c = 0;       


        public Wordlist(Form1 parent, string pathOfWordlist)
        {
            this.Parent = parent;
            this.Path = pathOfWordlist;
            GetSize();

        }

        public override void ElapsedTick(object sender, ElapsedEventArgs e)
        {
            Parent.UpdateLabelPassword((tmp != null) ? tmp.ToString() : "", count.ToString(), c.ToString());
            count = 0;
        }

        public string ZipAttack(ZipFile file)
        {
            Init();
            using (var reader = File.OpenText(this.Path))
            {
                string tempo;
                while ((tempo = reader.ReadLine()) != null)
                {
                RETRY:
                    tmp = new StringBuilder(reader.ReadLine());
                    count++;
                    file.Password = tmp.ToString();
                    file.UseZip64 = UseZip64.Dynamic;
                    file.BeginUpdate();
                    file.CommitUpdate();




                    foreach (ZipEntry item in file)
                    {
                        String entryFileName = item.Name;
                        byte[] buffer = new byte[4096];
                        string outputFold = Environment.CurrentDirectory + "\\tmp";
                        FastZip zip = new FastZip();
                        zip.Password = tmp.ToString();
                        c++;
                        try
                        {
                            zip.ExtractZip(file.Name, outputFold, null);
                        }
                        catch (ZipException zex)
                        {
                            goto RETRY;
                        }
                        catch (Exception ex)
                        {
                            goto RETRY;
                        }
                        Parent.Password = tmp.ToString();
                        Parent.PasswordFound.Set();
                        return tmp.ToString();
                    }
                }
            }
                        return tmp.ToString();
        }

        private void GetSize()
        {
            uint lineCount = 0;
            using (var reader = File.OpenText(this.Path))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }
            this.LineNumber = lineCount;
        }

        public void RarAttack()
        {
            throw new NotImplementedException();
        }

        public void Md5Attack()
        {
            throw new NotImplementedException();
        }

        public void Md4Attack()
        {
            throw new NotImplementedException();
        }

        public void Sha1Attack()
        {
            throw new NotImplementedException();
        }

        public void Sha256Attack()
        {
            throw new NotImplementedException();
        }

        public void Sha512Attack()
        {
            throw new NotImplementedException();
        }
    }
}
