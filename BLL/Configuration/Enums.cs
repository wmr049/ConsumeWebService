using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace BLL.Configuration
{
    public static class Enums
    {
        #region *** Enums ***

        /// <summary>
        /// Representa status de processamento do arquivo CNAB.
        /// </summary>
        public enum CnabStatus
        {            
            [StringValue("Concluído")]
            Concluido = 1,
            [StringValue("Erro ao processar arquivo CNAB")]
            Erro = 2
        }
                
        #endregion

        #region *** Classes Auxiliares ***

        /// <summary>
        /// Classe para tornar possível colocar uma anotação num enum.
        /// </summary>
        public class StringValueAttribute : Attribute
        {
            #region Properties

            /// <summary>
            /// Holds the stringvalue for a value in an enum.
            /// </summary>
            public string StringValue { get; protected set; }

            #endregion

            #region Constructor

            /// <summary>
            /// Constructor used to init a StringValue Attribute
            /// </summary>
            /// <param name="value"></param>
            public StringValueAttribute(string value)
            {
                this.StringValue = value;
            }

            #endregion
        }

        #endregion

        #region *** Métodos Auxiliares ***

        public static string GetStringValue(this Enum value)
        {
            // Get the type
            Type type = value.GetType();

            // Get fieldinfo for this type
            FieldInfo fieldInfo = type.GetField(value.ToString());

            // Get the stringvalue attributes
            StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(
                typeof(StringValueAttribute), false) as StringValueAttribute[];

            // Return the first if there was a match.
            return attribs.Length > 0 ? attribs[0].StringValue : null;
        }

        #endregion

    }
}
