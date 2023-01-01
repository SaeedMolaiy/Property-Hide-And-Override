
using System;

namespace PropertyHideVsOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HideBase hideBase = new HideBase();
            HideBase hided = new Hide();
            var hide = new Hide();

            Console.WriteLine("<------Hide------>");
            Console.WriteLine($"HideBase = new HideBase => {hideBase.X}");
            Console.WriteLine($"HideBase = new Hide => {hided.X}");
            Console.WriteLine($"Hide = new Hide => {hide.X}");
            Console.WriteLine("<---------------->");

            Console.WriteLine();

            OverrideBase overrideBase = new OverrideBase();
            OverrideBase overrided = new Override();
            var overRide = new Override();

            Console.WriteLine("<------Override------>");
            Console.WriteLine($"OverrideBase = new OverrideBase => {overrideBase.X}");
            Console.WriteLine($"OverrideBase = new Override => {overrided.X}");
            Console.WriteLine($"Override = new Override => {overRide.X}");
            Console.WriteLine("<---------------->");


            Console.ReadKey();
        }
    }

    public class HideBase
    {
        public int X { get; set; } = 0;
    }

    public class Hide : HideBase
    {
        // make sure use new keyword for hided property or properties (optional) but its better to use
        public new int X { get; set; } = 5;
    }

    public class OverrideBase
    {
        public virtual int X { get; set; } = 0;
    }

    public class Override : OverrideBase
    {
        public override int X { get; set; } = 5;
    }
}
