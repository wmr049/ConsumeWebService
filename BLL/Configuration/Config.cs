using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace BLL.Configuration
{
    /// <summary>
    /// Classe responsável por recuperar as chaves cadastradas no web.config
    /// </summary>
    public static class Config
    {
        #region sgpStatus

        public static int sgpStatusInativo
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpStatus.Inativo"]);
            }
        }

        public static int sgpStatusAtivo
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpStatus.Ativo"]);
            }
        }

        public static int sgpStatusAguardandoCancelamento
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpStatus.AguardandoCancelamento"]);
            }
        }

        public static int sgpStatusAguardandoCustodia
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpStatus.AguardandoCustodia"]);
            }
        }

        public static int sgpStatusAguardandoValidacao
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpStatus.AguardandoValidacao"]);
            }
        }

        public static int sgpStatusConcluido
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpStatus.Concluido"]);
            }
        }

        public static int sgpStatusAguardandoFinanciamento
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpStatus.AguardandoFinanciamento"]);
            }
        }

        public static int sgpStatusFinanciamentoAprovado
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpStatus.FinanciamentoAprovado"]);
            }
        }

        #endregion

        #region sgpTipoPagamento

        public static int sgpTipoPagamentoCheque
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpTipoPagamento.Cheque"]);
            }
        }

        #endregion

        #region sgpMotivoCancelamento

        public static int sgpMotivoCancelamentoTrocaCheques
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpMotivoCancelamento.TrocaCheques"]);
            }
        }

        public static int sgpMotivoCancelamentoTrocaCurso
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpMotivoCancelamento.TrocaCurso"]);
            }
        }

        public static int sgpMotivoCancelamentoDoencaFalecimento
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpMotivoCancelamento.DoencaFalecimento"]);
            }
        }

        public static int sgpMotivoCancelamentoAprovacaoConcurso
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpMotivoCancelamento.AprovacaoConcurso"]);
            }
        }

        public static int sgpMotivoCancelamentoDesistencia
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpMotivoCancelamento.Desistencia"]);
            }
        }

        public static int sgpMotivoCancelamentoErroCadastro
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpMotivoCancelamento.ErroCadastro"]);
            }
        }

        #endregion

        #region sgpMovimentacaoDetalhe
        public static int sgpMovimentacaoDetalheLiberacaoDeCredito
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpMovimentacaoDetalhe.LiberacaoDeCredito"]);
            }
        }
        #endregion

        #region Calculo

        /// <summary>
        /// Dias de carência.
        /// </summary>
        public static int DiasCarencia
        {
            get
            {
                return Util.getInt32(ConfigurationManager.AppSettings["Calculo.DiasCarencia"]);
            }
        }

        #endregion

        #region Custodia
        /// <summary>
        /// Dias que o aluno pode acessar o sistemas virtuais, antes de ser ativado
        /// </summary>
        public static int DiasAcessoSemCustodia
        {
            get
            {
                return Util.getInt32(ConfigurationManager.AppSettings["DiasAcessoSemCustodia"]);
            }
        }

        /// <summary>
        /// Valor maximo que pode ser gerado de credito na ultima parcela da custódia nova
        /// Solicitante: Felipe Renéa
        /// Chamado: 201112/009569
        /// </summary>
        public static decimal ValorMaximoCreditoCustodiaNova
        {
            get
            {
                return Convert.ToDecimal(ConfigurationManager.AppSettings["valMaxCreditoCustodiaNova"]);
            }
        }
        /// <summary>
        /// Valor maximo que pode ser gerado de credito na ultima parcela da custódia antiga
        /// Solicitante: Felipe Renéa
        /// Chamado: 201112/009825
        /// </summary>
        public static decimal ValorMaximoCreditoCustodiaAntiga
        {
            get
            {
                return Convert.ToDecimal(ConfigurationManager.AppSettings["valMaxCreditoCustodiaAntiga"]);
            }
        }
        /// <summary>
        /// Valor maximo que pode ser gerado de credito na ultima parcela da custódia antiga
        /// Solicitante: Felipe Renéa
        /// Chamado: 201112/009825
        /// </summary>
        public static int DiasPrimeiraParcelaBoleto
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["DiasPrimeiraParcelaBoleto"]);
            }
        }
        /// <summary>
        /// Valor que o sistema permite que o aluno pague o boleto a menor
        /// Solicitante: Marcio/Stephanie
        /// Chamado: 201204/008789
        /// </summary>
        public static decimal MargemPagamentoBoletoAMenor
        {
            get
            {
                return Convert.ToDecimal(ConfigurationManager.AppSettings["margemPagamentoBoletoAMenor"]);
            }
        }
        #endregion

        #region sgpStatusBoleto

        public static Int32 StatusBoletoAgPagamento
        {
            get
            {
                return Util.getInt32(ConfigurationManager.AppSettings["sgpStatusBoleto.AgPagamento"]);
            }
        }

        public static Int32 StatusBoletoPago
        {
            get
            {
                return Util.getInt32(ConfigurationManager.AppSettings["sgpStatusBoleto.Pago"]);
            }
        }

        public static Int32 StatusBoletoPendente
        {
            get
            {
                return Util.getInt32(ConfigurationManager.AppSettings["sgpStatusBoleto.Pendente"]);
            }
        }

        public static Int32 StatusBoletoCancelado
        {
            get
            {
                return Util.getInt32(ConfigurationManager.AppSettings["sgpStatusBoleto.Cancelado"]);
            }
        }

        public static Int32 StatusBoletoValorIncorreto
        {
            get
            {
                return Util.getInt32(ConfigurationManager.AppSettings["sgpStatusBoleto.ValorIncorreto"]);
            }
        }

        public static Int32 StatusBoletoNaoEncontrado
        {
            get
            {
                return Util.getInt32(ConfigurationManager.AppSettings["sgpStatusBoleto.NaoEncontrado"]);
            }
        }

        public static Int32 StatusBoletoConcluido
        {
            get
            {
                return Util.getInt32(ConfigurationManager.AppSettings["sgpStatusBoleto.Concluido"]);
            }
        }

        public static Int32 StatusBoletoDuplicado
        {
            get
            {
                return Util.getInt32(ConfigurationManager.AppSettings["sgpStatusBoleto.Duplicado"]);
            }
        }

        #endregion

        #region sgpUnidadeTipo

        public static Int32 sgpUnidadeTipoRedeEnsinoDesportivo
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["sgpUnidadeTipo.RedeEnsinoDesportivo"]);
            }
        }

        #endregion

        #region DNE
        public static String DneLogin
        {
            get
            {
                return Util.getString(ConfigurationManager.AppSettings["dne.login"]);
            }
        }
        public static String DneSenha
        {
            get
            {
                return Util.getString(ConfigurationManager.AppSettings["dne.senha"]);
            }
        }
        #endregion

        #region sgpCursoTipo

        public static String sgpCursoTipoPosGraduacaoNaoJuridica
        {
            get
            {
                return Util.getString(System.Configuration.ConfigurationManager.AppSettings["sgpCursoTipo.PosGraduacaoNaoJuridica"]);
            }
        }

        public static String sgpCursoTipoPosGraduacaoDesportiva
        {
            get
            {
                return Util.getString(System.Configuration.ConfigurationManager.AppSettings["sgpCursoTipo.PosGraduacaoDesportiva"]);
            }
        }

        public static String sgpCursoTipoPosGraduacaoJuridica
        {
            get
            {
                return Util.getString(System.Configuration.ConfigurationManager.AppSettings["sgpCursoTipo.PosGraduacaoJuridica"]);
            }
        }

        #endregion

        #region cygnus.GrupoCygnus

        public static String GrupoCygnusPosGraduacao
        {
            get
            {
                return Util.getString(System.Configuration.ConfigurationManager.AppSettings["GrupoCygnus.PosGraduacao"]);
            }
        }

        #endregion

        #region SPP
        public static int LimiteDiasAulaSPP
        {
            get
            {
                return Util.getInt32(System.Configuration.ConfigurationManager.AppSettings["LimiteDiasAulaSPP"]);
            }
        }
        #endregion

        /// <summary>
        /// Retorna o ambiente em que está a aplicação
        /// Possíveis valores: 
        ///     HOMOLOGACAO
        ///     PRODUCAO
        /// </summary>
        public static string  Ambiente { get { return Util.getString(ConfigurationManager.AppSettings["Ambiente"]).ToUpper(); } }

        #region Unidade de Conciliação - Integração bancária
        public static int UnidadeConciliacao { get { return Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["UnidadeConciliacao"]); } }
        #endregion

        #region Sistema em manutenção
        public static Boolean EmManutencao { get { return Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["EmManutencao"]); } }
        #endregion
    }
}
