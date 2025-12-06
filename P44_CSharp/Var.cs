using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P44_CSharp
{
    internal enum VarType
    {
        Int,
        Double,
        String,
        Unknown
    }

    internal class Var
    {
        private object value;
        private VarType type;

        public Var(int v)
        {
            value = v;
            type = VarType.Int;
        }

        public Var(double v)
        {
            value = v;
            type = VarType.Double;
        }

        public Var(string v)
        {
            value = v;
            type = VarType.String;
        }

        public static Var operator +(Var a, Var b)
        {
            if (a.type == VarType.Int && b.type == VarType.Int)
                return new Var((int)a.value + (int)b.value);
            if (a.type == VarType.Double && b.type == VarType.Double)
                return new Var((double)a.value + (double)b.value);
            if (a.type == VarType.Int && b.type == VarType.Double)
                return new Var((int)a.value + (double)b.value);
            if (a.type == VarType.Double && b.type == VarType.Int)
                return new Var((double)a.value + (int)b.value);
            if (a.type == VarType.String || b.type == VarType.String)
                return new Var(a.value.ToString() + b.value.ToString());
            throw new InvalidOperationException("Unsupported Var addition");
        }
    }
}
