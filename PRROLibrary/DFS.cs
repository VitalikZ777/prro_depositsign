using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRROLibrary
{
   public class DFS
    {
        public class ServerState
        {
            public string timestamp { get; set; }
        }
        public class LastShiftTotals
        {


            public string ShiftState { get; set; }

            public string ZRepPresent { get; set; }

            public ShiftTotals Totals { get; set; }

        }

        public class ShiftTotals
        {
            /// <summary>
            ///     Підсумки по зміні
            /// </summary>

            /// <summary>
                    ///     Підсумки реалізації
                    /// </summary>
            public ShiftTotalsOrderType Real { get; set; }

            /// <summary>
                    ///     Підсумки повернення
                    /// </summary>
            public ShiftTotalsOrderType Ret { get; set; }

            /// <summary>
                    ///     Підсумки видачі готівки
                    /// </summary>
            public ShiftTotalsCash Cash { get; set; }

            /// <summary>
                    ///     Підсумки операцій з іноземною валютою
                    /// </summary>
            public ShiftTotalsCurrency Currency { get; set; }

            /// <summary>
                    ///     Службове внесення/Отримання авансу/Отримання підкріплення
                    /// </summary>
            public decimal ServiceInput { get; set; }

            /// <summary>
                    ///     Службова видача/Інкасація
                    /// </summary>
            public decimal ServiceOutput { get; set; }

        }
        /// <summary>
        ///     Підсумки по типу чека
        /// </summary>
        public class ShiftTotalsOrderType
        {
            /// <summary>
                ///     Загальна сума
                /// </summary>
            public decimal Sum { get; set; }

            /// <summary>
                ///     Заокруглення (наприклад, 0.71)
                /// </summary>
            public decimal RndSum { get; set; }

            /// <summary>
                ///     Загальна сума без заокруглення (наприклад, 1000.71)
                /// </summary>
            public decimal NoRndSum { get; set; }

            /// <summary>
                ///     Загальна сума комісії від переказу коштів
                /// </summary>
            public decimal TotalCurrencyCommission { get; set; }

            /// <summary>
                ///     Кількість чеків
                /// </summary>
            public int OrdersCount { get; set; }

            /// <summary>
                ///     Кількість операції переказу коштів
                /// </summary>
            public int TotalCurrencyCost { get; set; }

            /// <summary>
                ///     Підсумки по формам оплати
                /// </summary>
            public List<ShiftTotalsPayForm> PayForm { get; set; }

            /// <summary>
                ///     Податки/збори
                /// </summary>
            public List<ShiftTotalsTax> Tax { get; set; }
        }

        /// <summary>
        ///     Підсумки по формам оплати
        /// </summary>
        public class ShiftTotalsPayForm
        {
            public int PayFormCode { get; set; } // Код форми оплати
            public string PayFormName { get; set; } // Найменування форми оплати
            public decimal Sum { get; set; } // Сума оплати
        }

        /// <summary>
        ///     Податки/збори
        /// </summary>
        public class ShiftTotalsTax
        {
            public int Type { get; set; } // Код виду податку/збору
            public string Name { get; set; } // Найменування виду податку/збору
            public string Letter { get; set; } // Літерне позначення виду і ставки податку/збору
            public decimal Prc { get; set; } // Відсоток податку/збору
            public bool Sign { get; set; } // Ознака податку/збору, не включеного у вартість
            public decimal Turnover { get; set; } // Сума обсягів для розрахування податку/збору
            public decimal SourceSum { get; set; } // Вихідна сума для розрахування податку/збору
            public decimal Sum { get; set; } // Сума податку/збору
        }

        /// <summary>
        ///     Підсумки видачі готівки
        /// </summary>
        public class ShiftTotalsCash
        {
            /// <summary>
                ///     Загальна сума
                /// </summary>
            public decimal Sum { get; set; }

            /// <summary>
                ///     Загальна сума комісії
                /// </summary>
            public decimal Commission { get; set; }

            /// <summary>
                ///     Кількість чеків
                /// </summary>
            public int OrdersCount { get; set; }
        }

        /// <summary>
        ///     Підсумки операцій з іноземною валютою
        /// </summary>
        public class ShiftTotalsCurrency
        {
            /// <summary>
                ///     Отримано авансів національною валютою
                /// </summary>
            public decimal TotalInAdvance { get; set; }

            /// <summary>
                ///     Отримано підкріплень національною валютою
                /// </summary>
            public decimal TotalInAttach { get; set; }

            /// <summary>
                ///     Здано по інкасації національною валютою
                /// </summary>
            public decimal TotalSurrCollection { get; set; }

            /// <summary>
                ///     Отримано комісії конвертації
                /// </summary>
            public decimal Commission { get; set; }

            /// <summary>
                ///     Кількість розрахункових документів за зміну
                /// </summary>
            public int CalcDocsCnt { get; set; }

            /// <summary>
                ///     Прийнято національної валюти для переказу
                /// </summary>
            public decimal AcceptedN { get; set; }

            /// <summary>
                ///     Видано національної валюти при виплаті переказу
                /// </summary>
            public decimal IssuedN { get; set; }

            /// <summary>
                ///     Отримано комісії в національній валюті при здійсненні переказів
                /// </summary>
            public decimal CommissionN { get; set; }

            /// <summary>
                ///     Кількість операцій (документів) переказів або виплат переказів
                /// </summary>
            public int TransfersCnt { get; set; }

            /// <summary>
                ///     Підсумки по видам іноземної валюти
                /// </summary>
            public List<TotalsCurrencyDetails> Details { get; set; }
        }

        /// <summary>
        ///     Підсумки по виду іноземної валюти
        /// </summary>
        public class TotalsCurrencyDetails
        {
            /// <summary>
                ///     Код валюти
                /// </summary>
            public int ValCd { get; set; }

            /// <summary>
                ///     Символьний код валюти
                /// </summary>
            public string ValSymCd { get; set; }

            /// <summary>
                ///     Загальна сума придбаної іноземної валюти
                /// </summary>
            public decimal BuyValI { get; set; }

            /// <summary>
                ///     Загальна сума проданої іноземної валюти
                /// </summary>
            public decimal SellValI { get; set; }

            /// <summary>
                ///     Загальна сума придбаної національної валюти
                /// </summary>
            public decimal BuyValN { get; set; }

            /// <summary>
                ///     Загальна сума проданої національної валюти
                /// </summary>
            public decimal SellValN { get; set; }

            /// <summary>
                ///     Загальна сума поверненої клієнтами іноземної валюти за операціями «сторно»
                /// </summary>
            public decimal StorBuyValI { get; set; }

            /// <summary>
                ///     Загальна сума виданої клієнтам національної валюти за операціями «сторно»
                /// </summary>
            public decimal StorSellValI { get; set; }

            /// <summary>
                ///     Загальна сума поверненої клієнтами національної валюти за операціями «сторно»
                /// </summary>
            public decimal StorBuyValN { get; set; }

            /// <summary>
                ///     Загальна сума виданої клієнтам національної валюти за операціями «сторно»
                /// </summary>
            public decimal StorSellValN { get; set; }

            /// <summary>
                ///     Загальна сума прийнятої іноземної валюти за операціями конвертації
                /// </summary>
            public decimal CInValI { get; set; }

            /// <summary>
                ///     Загальна сума виданої іноземної валюти за операціями конвертації
                /// </summary>
            public decimal COutValI { get; set; }

            /// <summary>
                ///     Загальна сума комісії за операціями конвертації
                /// </summary>
            public decimal Commission { get; set; }

            /// <summary>
                ///     Отримано авансів
                /// </summary>
            public decimal InAdvance { get; set; }

            /// <summary>
                ///     Отримано підкріплень
                /// </summary>
            public decimal InAttach { get; set; }

            /// <summary>
                ///     Здано по інкасації
                /// </summary>
            public decimal SurrCollection { get; set; }

            /// <summary>
                ///     Видано іноземної валюти по сторно конвертації
                /// </summary>
            public decimal StorCInValI { get; set; }

            /// <summary>
                ///     Повернуто іноземної валюти по сторно конвертації
                /// </summary>
            public decimal StorCOutValI { get; set; }

            /// <summary>
                ///     Повернуто суму комісії з сторно конвертації
                /// </summary>
            public decimal StorCommission { get; set; }
        }




       
        public class PayForm
        {
            public int PayFormCode { get; set; }
            public string PayFormName { get; set; }
            public double Sum { get; set; }
        }

        public class Tax
        {
            public int Type { get; set; }
            public string Name { get; set; }
            public string Letter { get; set; }
            public double Prc { get; set; }
            public bool Sign { get; set; }
            public double Turnover { get; set; }
            public double SourceSum { get; set; }
            public double Sum { get; set; }
        }

        public class Real
        {
            public double Sum { get; set; }
            public double RndSum { get; set; }
            public double NoRndSum { get; set; }
            public double TotalCurrencyCommission { get; set; }
            public int OrdersCount { get; set; }
            public int TotalCurrencyCost { get; set; }
            public List<PayForm> PayForm { get; set; }
            public List<Tax> Tax { get; set; }
        }

        public class Totals
        {
            public Real Real { get; set; }
            public object Ret { get; set; }
            public object Cash { get; set; }
            public object Currency { get; set; }
            public double ServiceInput { get; set; }
            public double ServiceOutput { get; set; }
        }
        public class TransactionsRegistrarState
        {
            public int ShiftState { get; set; }
            public int ShiftId { get; set; }
            public string OpenShiftFiscalNum { get; set; }
            public bool ZRepPresent { get; set; }
            public string Name { get; set; }
            public string SubjectKeyId { get; set; }
            public int FirstLocalNum { get; set; }
            public int NextLocalNum { get; set; }
            public string LastFiscalNum { get; set; }
            public bool OfflineSupported { get; set; }
            public bool ChiefCashier { get; set; }
            public string OfflineSessionId { get; set; }
            public string OfflineSeed { get; set; }
            public string OfflineNextLocalNum { get; set; }
            public string OfflineSessionDuration { get; set; }
            public string OfflineSessionsMonthlyDuration { get; set; }
            public bool Closed { get; set; }
            public object TaxObject { get; set; }

        }

    }
}
