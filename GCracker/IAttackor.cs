using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCracker
{
    public interface IAttackor
    {

        string ZipAttack(ZipFile archive);

        void RarAttack();

        void Md5Attack();

        void Md4Attack();

        void Sha1Attack();

        void Sha256Attack();

        void Sha512Attack();

        void Stop();

    }
}
