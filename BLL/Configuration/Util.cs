using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Configuration
{
    /// <summary>
    /// Funções básicas para tratamento de parâmetros e entidades.
    /// </summary>
    public static class Util
    {

        #region Enums

        /// <summary>
        /// Representa os possíveis valores booleanos.
        /// </summary>
        public enum ValoresBooleanos
        {
            S,
            Y,
            N
        }

        #endregion

        #region Métodos e Funções

        /// <summary>
        /// Extrair número de uma determinada string.
        /// </summary>
        /// <param name="value">Valor que contém os números a serem extraídos.</param>
        /// <returns>String com os números encontrados.</returns>
        public static string ExtractNumbers(string value)
        {
            return string.Join(null, System.Text.RegularExpressions.Regex.Split(value, "[^\\d]"));
        }

        /// <summary>
        /// Obter valor do tipo String.
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <param name="valorNulo">Valor a ser retornado caso o valor seja valor.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna valorNulo.
        /// </returns>
        public static string getString(object valor, string valorNulo)
        {
            if ((valor == null) || (valor.Equals(DBNull.Value)) || (valor.Equals(String.Empty)))
            {
                return valorNulo;
            }
            else
            {
                return valor.ToString();
            }
        }

        /// <summary>
        /// Obter valor do tipo String.
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna String.Empty.
        /// </returns>
        public static string getString(object valor)
        {
            return getString(valor, string.Empty);
        }

        /// <summary>
        /// Obter valor do tipo inteiro (Int32).
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <param name="valorNulo">Valor a ser retornado caso o valor seja nulo.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna valorNulo.
        /// </returns>
        public static Int32 getInt32(object valor, Int32 valorNulo)
        {
            if ((valor == null) || (valor.Equals(DBNull.Value)) || (valor.Equals(String.Empty)))
            {
                return valorNulo;
            }
            else
            {
                return Convert.ToInt32(valor);
            }
        }

        /// <summary>
        /// Obter valor do tipo inteiro (Int32).
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna 0.
        /// </returns>
        public static Int32 getInt32(object valor)
        {
            return getInt32(valor, (Int32)decimal.Zero);
        }

        /// <summary>
        /// Obter valor do tipo inteiro (Int16).
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <param name="valorNulo">Valor a ser retornado caso o valor seja nulo.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna valorNulo.
        /// </returns>
        public static Int16 getInt16(object valor, Int16 valorNulo)
        {
            if ((valor == null) || (valor.Equals(DBNull.Value)) || (valor.Equals(String.Empty)))
            {
                return valorNulo;
            }
            else
            {
                return Convert.ToInt16(valor);
            }
        }

        /// <summary>
        /// Obter valor do tipo inteiro (Int16).
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna 0.
        /// </returns>
        public static Int16 getInt16(object valor)
        {
            return getInt16(valor, (Int16)decimal.Zero);
        }

        /// <summary>
        /// Obter valor do tipo inteiro (Int64).
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <param name="valorNulo">Valor a ser retornado caso o valor seja nulo.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna valorNulo.
        /// </returns>
        public static Int64 getInt64(object valor, Int64 valorNulo)
        {
            if ((valor == null) || (valor.Equals(DBNull.Value)) || (valor.Equals(String.Empty)))
            {
                return valorNulo;
            }
            else
            {
                return Convert.ToInt64(valor);
            }
        }

        /// <summary>
        /// Obter valor do tipo inteiro (Int64).
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna 0.
        /// </returns>
        public static Int64 getInt64(object valor)
        {
            return getInt64(valor, (Int64)decimal.Zero);
        }

        /// <summary>
        /// Obter valor do tipo decimal.
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <param name="valorNulo">Valor a ser retornado caso o valor seja nulo.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna valorNulo.
        /// </returns>
        public static decimal getDecimal(object valor, decimal valorNulo)
        {
            if ((valor == null) || (valor.Equals(DBNull.Value)) || (valor.Equals(String.Empty)))
            {
                return valorNulo;
            }
            else
            {
                return Convert.ToDecimal(valor);
            }
        }

        /// <summary>
        /// Obter valor do tipo decimal.
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna 0.
        /// </returns>
        public static decimal getDecimal(object valor)
        {
            return getDecimal(valor, decimal.Zero);
        }

        /// <summary>
        /// Obter valor do tipo DateTime.
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <param name="valorNulo">Valor a ser retornado caso o valor seja nulo.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna valorNulo.
        /// </returns>
        public static DateTime getDateTime(object valor, DateTime valorNulo)
        {
            if ((valor == null) || (valor.Equals(DBNull.Value)) || (valor.Equals(String.Empty)))
            {
                return valorNulo;
            }
            else
            {
                return Convert.ToDateTime(valor);
            }
        }

        /// <summary>
        /// Obter valor do tipo DateTime.
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna DateTime.MinValue.
        /// </returns>
        public static DateTime getDateTime(object valor)
        {
            return getDateTime(valor, DateTime.MinValue);
        }

        /// <summary>
        /// Obter valor do tipo Booleano.
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <param name="valorNulo">Valor a ser retornado caso o valor seja nulo.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna valorNulo.
        /// </returns>
        public static bool getBoolean(object valor, bool valorNulo)
        {

            if ((valor == null) || (valor.Equals(DBNull.Value)))
            {
                return valorNulo;
            }
            else
            {
                // Verificar tipo recebido.
                if (valor.GetType() == typeof(String))
                {
                    // Valor recebido é do tipo string, converter para booleano.
                    if (valor.ToString() == ValoresBooleanos.S.ToString() || valor.ToString() == ValoresBooleanos.Y.ToString())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    // Tentar conversão.
                    return Convert.ToBoolean(valor);
                }

            }
        }

        /// <summary>
        /// Obter valor do tipo Boolean.
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna False.
        /// </returns>
        public static bool getBoolean(object valor)
        {
            return getBoolean(valor, false);
        }

        /// <summary>
        /// Obter valor do tipo double.
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <param name="valorNulo">Valor a ser retornado caso o valor seja nulo.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna valorNulo.
        /// </returns>
        public static double getDouble(object valor, double valorNulo)
        {
            if ((valor == null) || (valor.Equals(DBNull.Value)) || (valor.Equals(String.Empty)))
            {
                return valorNulo;
            }
            else
            {
                return Convert.ToDouble(valor);
            }
        }

        /// <summary>
        /// Obter valor do tipo double.
        /// </summary>
        /// <param name="valor">Valor a ser recuperado/tratado.</param>
        /// <returns>
        ///     Retorna o próprio parâmetro valor, ou, para valores nulos, retorna 0.
        /// </returns>
        public static double getDouble(object valor)
        {
            return getDouble(valor, Convert.ToDouble(decimal.Zero));
        }

        /// <summary>
        /// Verifica se um determinado valor é nulo.
        /// </summary>
        /// <param name="valor">Valor a ser verificado.</param>
        /// <returns>Flag.</returns>
        public static bool IsNullOrEmpty(object valor)
        {
            return ((valor == null) || (valor.Equals(DBNull.Value)) || (valor.Equals(String.Empty)));
        }

        /// <summary>
        /// Retirar todos os acentos do texto informado
        /// </summary> 
        /// <param name="texto">String para retirar acentos</param>
        /// <returns>String do texto sem acentos</returns>
        public static string TirarAcentos(string texto)
        {
            string textor = "";

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i].ToString() == "ã") textor += "a";
                else if (texto[i].ToString() == "á") textor += "a";
                else if (texto[i].ToString() == "à") textor += "a";
                else if (texto[i].ToString() == "â") textor += "a";
                else if (texto[i].ToString() == "ä") textor += "a";
                else if (texto[i].ToString() == "é") textor += "e";
                else if (texto[i].ToString() == "è") textor += "e";
                else if (texto[i].ToString() == "ê") textor += "e";
                else if (texto[i].ToString() == "ë") textor += "e";
                else if (texto[i].ToString() == "í") textor += "i";
                else if (texto[i].ToString() == "ì") textor += "i";
                else if (texto[i].ToString() == "ï") textor += "i";
                else if (texto[i].ToString() == "õ") textor += "o";
                else if (texto[i].ToString() == "ó") textor += "o";
                else if (texto[i].ToString() == "ò") textor += "o";
                else if (texto[i].ToString() == "ö") textor += "o";
                else if (texto[i].ToString() == "ô") textor += "o";
                else if (texto[i].ToString() == "ú") textor += "u";
                else if (texto[i].ToString() == "ù") textor += "u";
                else if (texto[i].ToString() == "ü") textor += "u";
                else if (texto[i].ToString() == "û") textor += "u";
                else if (texto[i].ToString() == "ç") textor += "c";
                else textor += texto[i];
            }
            return textor;
        }

        #endregion

    }
}
