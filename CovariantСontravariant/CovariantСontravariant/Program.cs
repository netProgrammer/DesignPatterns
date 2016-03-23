using System;

namespace CovariantСontravariant
{
    internal delegate Name Ui(FamilyAndName obj);

    public class Name
    {
        public string MyName;

        public override string ToString()
        {
            return MyName;
        }
    }

    public class FamilyAndName : Name
    {
        public string Family;

        public override string ToString()
        {
            return Family;
        }
    }

    public class UserInfo
    {
        public static Name UiName(Name obj)
        {
            obj.MyName = "User name is: \"" + obj.MyName + "\"";
            return obj;
        }

        public static FamilyAndName UiFamilyName(FamilyAndName obj)
        {
            obj.Family = "First and Last name is \"" + obj.MyName + " " + obj.Family + "\"";
            return obj;
        }
    }

    class Program
    {
        static void Main()
        {
            //Covariant
            Ui user = UserInfo.UiFamilyName;
            var covariant = user(new FamilyAndName {Family = "Family", MyName = "Name"});
            Console.WriteLine(covariant);

            //Сontravariant
            user = UserInfo.UiName;
            var contravariant = user(new FamilyAndName {Family = "Family", MyName = "Name"});
            Console.WriteLine(contravariant);
            Console.ReadLine();
        }
    }
}
