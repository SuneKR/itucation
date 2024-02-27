namespace InterfaceDemo
{
    /*
     * Interfaces are
     * 1. 100% Abstract, no need to write keyword 'Abstract'
     * 2. You cannot create instance/object
     * 3. You can implement many interfaces in a single class
     * 4. Naming convention: Name start with 'I'
     */

    public interface IOneInterface
    {
        //int tal //not allowed
        //(public int MyProperty { get; set; } //allowed recently
        public void ShowOne();
        public void ShowDefault() //allowed recently
        {
            Console.WriteLine("Method declared in IOneInterface");
        }
    }

    public class AnyClass : IOneInterface
    {
        public void ShowOne()
        {
            Console.WriteLine("Mothod declared in AnyClass");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AnyClass anyClass = new AnyClass();
            anyClass.ShowOne();

            Barn barn = new Barn();
            barn.Height();
            barn.Intelligence();
            barn.Experience();
            //barn.ShowDefault(); //not recognized

            IOneInterface barn2 = new Barn(); //Hard interface implementation
            //barn2.Height(); //not recognized
            //barn2.Intelligence(); //not recognized
            //barn2.Experience(); //not recognized
            barn2.ShowOne();
            barn2.ShowDefault(); //recognized
        }
    }
}
