using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegurSys
{
    class clnUtil
    {
        private string _cpf, _inicioTurno, _fimTurno, _inicioIntervalo, _fimIntervalo, _dataOcorrencia, _inicioOcorrencia, _fimOcorrencia;

        public string Cpf { get => _cpf; set => _cpf = value; }
        public string InicioTurno { get => _inicioTurno; set => _inicioTurno = value; }
        public string FimTurno { get => _fimTurno; set => _fimTurno = value; }
        public string InicioIntervalo { get => _inicioIntervalo; set => _inicioIntervalo = value; }
        public string FimIntervalo { get => _fimIntervalo; set => _fimIntervalo = value; }
        public string DataOcorrencia { get => _dataOcorrencia; set => _dataOcorrencia = value; }
        public string InicioOcorrencia { get => _inicioOcorrencia; set => _inicioOcorrencia = value; }
        public string FimOcorrencia { get => _fimOcorrencia; set => _fimOcorrencia = value; }


        public bool ValidaCpf()
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;

            int soma;
            int resto;

            _cpf = _cpf.Trim();
            _cpf = _cpf.Replace(".", "").Replace("-", "");

            if (_cpf.Length != 11 || _cpf == "11111111111" || _cpf == "22222222222" || _cpf == "33333333333" || _cpf == "44444444444" ||
                _cpf == "55555555555" || _cpf == "66666666666" || _cpf == "77777777777" || _cpf == "88888888888" || _cpf == "99999999999")
            {
                return false;
            }
            tempCpf = _cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * (multiplicador1[i]);
            }
            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            int soma2 = 0;

            for (int i = 0; i < 10; i++)
            {
                soma2 += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }

            resto = soma2 % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = digito + resto.ToString();
            return _cpf.EndsWith(digito);
        }
        public static bool validarHoraNull(string hora)
        {
            if(hora.Length == 0)
            {
                return true;
            }
            else
            {
                return ValidarHora(hora);
            }
        }
        public static bool ValidarHora(string hora)
        {
            int parte1;
            int parte2;
            hora.Replace(" ", "");
            if (hora.Length != 4)
            {
                return false;
            }
            else if (hora.Length == 4 && hora.IndexOf(" ") == -1)
            {
                string pt1 = (hora.Substring(0, 2));
                string pt2 = (hora.Substring(2));
                parte1 = Convert.ToInt32(pt1);
                parte2 = Convert.ToInt32(pt2);

                if (parte1 <= 23 && parte2 <= 59)
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
                return false;
            }
        }
        public bool ValidarData()
        {
            int parte1;
            int parte2;
            int parte3;
            if (_dataOcorrencia.Length != 8)
            {
                return false;
            }
            else if (_dataOcorrencia.Length == 8 && _dataOcorrencia.IndexOf(" ") == -1)
            {
                string pt1 = (_dataOcorrencia.Substring(0, 2));
                string pt2 = (_dataOcorrencia.Substring(2, 2));
                string pt3 = (_dataOcorrencia.Substring(4, 4));
                parte1 = Convert.ToInt32(pt1);
                parte2 = Convert.ToInt32(pt2);
                parte3 = Convert.ToInt32(pt3);
                string anoAtual = DateTime.Now.ToString().Replace("/", "").Substring(4, 4);
                string mesAtual = DateTime.Now.ToString().Replace("/", "").Substring(2, 2);
                string diaAtual = DateTime.Now.ToString().Replace("/", "").Substring(0, 2);
                int ano = Convert.ToInt32(anoAtual);
                int mes = Convert.ToInt32(mesAtual);
                int dia = Convert.ToInt32(diaAtual);

                if (parte1 <= 31 && parte1 > 0 && parte2 <= 12 && parte2 > 0 && parte3 >= ano)
                {
                    if(!(parte3 > ano) && !(parte1 > dia) && !(parte2 > mes))
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
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public string DiaSemanaEmPtBr()
        {
            string diaSemana = "";
            string diaEmIngês = DateTime.Now.DayOfWeek.ToString();

            if (diaEmIngês == "Sunday")
            {
                diaSemana = "Domingo";
            }
            else if (diaEmIngês == "Monday")
            {
                diaSemana = "Segunda";
            }
            else if (diaEmIngês == "Tuesday")
            {
                diaSemana = "Terça";
            }
            else if (diaEmIngês == "Wednesday")
            {
                diaSemana = "Quarta";
            }
            else if (diaEmIngês == "Thursday")
            {
                diaSemana = "Quinta";
            }
            else if (diaEmIngês == "Friday")
            {
                diaSemana = "Sexta";
            }
            else if (diaEmIngês == "Saturday")
            {
                diaSemana = "Sábado";
            }
            return diaSemana;
        }

        public string DiaSemanaOntem()
        {
            string diaSemanaAnterior = "";
            string diaEmIngês = DateTime.Now.DayOfWeek.ToString();

            if (diaEmIngês == "Sunday")
            {
                diaSemanaAnterior = "Sábado";
            }
            else if (diaEmIngês == "Monday")
            {
                diaSemanaAnterior = "Domingo";
            }
            else if (diaEmIngês == "Tuesday")
            {
                diaSemanaAnterior = "Segunda";
            }
            else if (diaEmIngês == "Wednesday")
            {
                diaSemanaAnterior = "Terça";
            }
            else if (diaEmIngês == "Thursday")
            {
                diaSemanaAnterior = "Quarta";
            }
            else if (diaEmIngês == "Friday")
            {
                diaSemanaAnterior = "Quinta";
            }
            else if (diaEmIngês == "Saturday")
            {
                diaSemanaAnterior = "Sexta";
            }
            return diaSemanaAnterior;
        }
        public static bool DentroHoraAtual(string x, string y)
        {
            DateTime agora = DateTime.Now;
            DateTime ini = Convert.ToDateTime(x);
            DateTime fim = Convert.ToDateTime(y);

            if (ini > fim)
            {
                fim = fim.AddDays(1);
            }
            if (ini < agora && fim > agora)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DentroHoraAtualOntem(string x, string y)
        {
            DateTime agora = DateTime.Now;
            DateTime ini = Convert.ToDateTime(x);
            DateTime fim = Convert.ToDateTime(y);

            if (ini > fim)
            {
                fim = fim.AddDays(1);
            }
            fim = fim.AddDays(-1);
            ini = fim.AddDays(-1);

            if (ini < agora && fim > agora)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidarSenha(string senha)
        {
            if (senha.Length >= 6)
            {
                if (senha.Any(s => char.IsUpper(s)) || senha.Any(s => char.IsLower(s)))
                {
                    if (senha.Any(s => char.IsDigit(s))) return true;
                    else return false;
                }
                else return false;
            }
            else if (senha.Length > 11) return true;
            else return false;
        }
        public void ApenasNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}