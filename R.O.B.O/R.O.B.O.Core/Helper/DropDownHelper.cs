using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace R.O.B.O.Core.Helper
{
    public static class DropDownHelper
    {

        /// <summary>
        /// Cria uma Select List Item a partir de um ENUM, sendo seu Value = Código do ENUM e Text = DisplayName do ENUM
        /// </summary>
        /// <param name="defaultValue">Parâmetro para a inserção de opção default 'SELECIONE', na primeira posição da lista</param>
        /// <returns></returns>
        public static void PopularDropDownPorEnum<T>(this DropDownList dropDownList,bool defaultValue = true) where T : struct
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
                    Text = nome
                };

                valoresDropDown.Add(selectListItem);
            }

            if (defaultValue) 
            {
                var defaultListItem = new SelectListItem { Text = "Selecione", Value = "" };
                valoresDropDown.Insert(0, defaultListItem); 
            }

            PreencherDropDown(dropDownList, valoresDropDown);
        }

        public static void PreencherDropDown(DropDownList dropDownList, List<SelectListItem> valoresDropDown)
        {
            dropDownList.DataValueField = "Value";
            dropDownList.DataTextField = "Text";
            dropDownList.DataSource = valoresDropDown;
            dropDownList.DataBind();
        }
    }
}
