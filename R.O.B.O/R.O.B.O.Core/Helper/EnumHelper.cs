using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace R.O.B.O.Core.Helper
{
    public class EnumHelper<T> where T : struct
    {
        SelectListItem defaultListItem;

        public EnumHelper()
        {
            defaultListItem = new SelectListItem { Text = "SELECIONE", Value = "" };
        }

        /// <summary>
        /// Cria uma Select List Item a partir de um ENUM, sendo seu Value = Código do ENUM e Text = DisplayName do ENUM
        /// </summary>
        /// <param name="defaultValue">Parâmetro para a inserção de opção default 'SELECIONE', na primeira posição da lista</param>
        /// <returns></returns>
        public List<SelectListItem> PopularDropDownPorEnum(bool defaultValue = true)
        {
            var tipoEnum = typeof(T);

            var valoresDropDown = new List<SelectListItem>();
            var valoresEnum = Enum.GetValues(tipoEnum);

            foreach (var item in valoresEnum)
            {
                var membroEnumInfo = tipoEnum.GetMember(item.ToString()).FirstOrDefault();

                var valor = Convert.ToInt32(Enum.Parse(tipoEnum, membroEnumInfo.Name));
                var nome = membroEnumInfo.GetCustomAttribute<DisplayAttribute>().Name;

                var selectListItem = new SelectListItem
                {
                    Value = Convert.ToString(valor),
                    Text = nome.ToUpper()
                };

                valoresDropDown.Insert(0, selectListItem);
            }

            if (defaultValue) valoresDropDown.Insert(0, defaultListItem);
            return valoresDropDown;
        }
    }
}
