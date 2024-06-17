using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace R.O.B.O.Core.Extensions
{
    public static class EnumExtensions
    {
        public static string ObterDisplayName(this Enum valor)
        {
            var campo = valor.GetType().GetField(valor.ToString());
            var atributo = campo.GetCustomAttribute<DisplayAttribute>();
            return atributo == null ? valor.ToString() : atributo.Name;
        }
    }
}
