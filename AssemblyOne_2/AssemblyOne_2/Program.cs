using System;

namespace AssemblyOne_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassPublic classPublic = new ClassPublic();
            Console.WriteLine(classPublic.numPub);

            ClassProtected classProtected = new ClassProtected();
            //Console.WriteLine(class.numProt); ошибка

            ClassInternal classInternal = new ClassInternal();
            Console.WriteLine(classInternal.numInt);

            ClassProtectedInternal classProtectedInternal = new ClassProtectedInternal();
            Console.WriteLine(classProtectedInternal.numProtInt);

            ClassPrivate classPrivate = new ClassPrivate();
            //Console.WriteLine(classPrivate.numPriv); ошибка

            ClassPrivateProtected classPrivateProtected = new ClassPrivateProtected();
            //Console.WriteLine(classPrivateProtected.numPrivProt); ошибка
        }
    }
}
