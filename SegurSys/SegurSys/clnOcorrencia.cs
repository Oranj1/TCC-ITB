using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurSys
{
    class clnOcorrencia
    {
        cldBancoDados ObjBancoDados = new cldBancoDados();

        private string _dataRegistroeHoraRegistro, _id, _texto, _dataAcontecimento, _nivel, _inicio, _fim, _area, _idVistoPor = "", _status, _idOco;
        string comando;

        public string DataRegistroeHoraRegistro { get => _dataRegistroeHoraRegistro; set => _dataRegistroeHoraRegistro = value; }
        public string Id { get => _id; set => _id = value; }
        public string Texto { get => _texto; set => _texto = value; }
        public string DataAcontecimento { get => _dataAcontecimento; set => _dataAcontecimento = value; }
        public string Nivel { get => _nivel; set => _nivel = value; }
        public string Inicio { get => _inicio; set => _inicio = value; }
        public string Fim { get => _fim; set => _fim = value; }
        public string Area { get => _area; set => _area = value; }
        public string IdVistoPor { get => _idVistoPor; set => _idVistoPor = value; }
        public string Status { get => _status; set => _status = value; }
        public string IdOco { get => _idOco; set => _idOco = value; }


        public DateTime DataEHoraAtual()
        {
            DateTime atual = DateTime.Now;
            return atual;
        }
        public string HoraAtual()
        {
            string horaAtualAterar;
            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();

            if (hour.Length == 1)
            {
                hour = "0" + hour;
            }

            if (minute.Length == 1)
            {
                minute = "0" + minute;
            }

            return horaAtualAterar = (hour + ":" + minute);
        }

        public void RegistrarOcorrencia()
        {
            DataEHoraAtual();
            _dataRegistroeHoraRegistro = DataEHoraAtual().ToString();
            if (_idVistoPor != "")
            {
                if (_fim != "")
                {
                    comando = "INSERT INTO Ocorrencia (nivel_ocorrencia, data_acontecimento, acontecimento, hora_do_termino, hora_de_inicio, hora_data_registro, id_area, id_func, visto_por, _status) VALUES (";
                    comando += "'" + _nivel + "', ";
                    comando += "'" + _dataAcontecimento + "', ";
                    comando += "'" + _texto + "', ";
                    comando += "'" + _fim + "', ";
                    comando += "'" + _inicio + "', ";
                    comando += "'" + _dataRegistroeHoraRegistro + "', ";
                    comando += "'" + _area + "', ";
                    comando += "'" + _id + "',";
                    comando += "'" + _idVistoPor + "', ";
                    comando += "'" + _status + "')";
                }
                else
                {
                    comando = "INSERT INTO Ocorrencia (nivel_ocorrencia, data_acontecimento, acontecimento, hora_de_inicio, hora_data_registro, id_area, id_func, visto_por, _status) VALUES (";
                    comando += "'" + _nivel + "', ";
                    comando += "'" + _dataAcontecimento + "', ";
                    comando += "'" + _texto + "', ";
                    comando += "'" + _inicio + "', ";
                    comando += "'" + _dataRegistroeHoraRegistro + "', ";
                    comando += "'" + _area + "', ";
                    comando += "'" + _id + "',";
                    comando += "'" + _idVistoPor + "', ";
                    comando += "'" + _status + "')";
                }
            }
            else
            {
                if (_fim != "")
                {
                    comando = "INSERT INTO Ocorrencia (nivel_ocorrencia, data_acontecimento, acontecimento, hora_do_termino, hora_de_inicio, hora_data_registro, id_area, id_func, _status) VALUES (";
                    comando += "'" + _nivel + "', ";
                    comando += "'" + _dataAcontecimento + "', ";
                    comando += "'" + _texto + "', ";
                    comando += "'" + _fim + "', ";
                    comando += "'" + _inicio + "', ";
                    comando += "'" + _dataRegistroeHoraRegistro + "', ";
                    comando += "'" + _area + "', ";
                    comando += "'" + _id + "', ";
                    comando += "'" + _status + "')";
                }
                else
                {
                    comando = "INSERT INTO Ocorrencia (nivel_ocorrencia, data_acontecimento, acontecimento, hora_de_inicio, hora_data_registro, id_area, id_func, _status) VALUES (";
                    comando += "'" + _nivel + "', ";
                    comando += "'" + _dataAcontecimento + "', ";
                    comando += "'" + _texto + "', ";
                    comando += "'" + _inicio + "', ";
                    comando += "'" + _dataRegistroeHoraRegistro + "', ";
                    comando += "'" + _area + "', ";
                    comando += "'" + _id + "', ";
                    comando += "'" + _status + "')";
                }
            }
            ObjBancoDados.ExecutaComando(comando);
        }
        public void MudarStatus()
        {
            if (_status == "Solucionado")
            {
                _fim = HoraAtual();
                comando = "update Ocorrencia set ";
                comando += "_status = '" + _status + "', ";
                comando += "hora_do_termino = '" + _fim + "' ";
                comando += "where id_ocorrencia = '" + _idOco + "'";
            }
            else
            {
                comando = "update Ocorrencia set ";
                comando += "_status = '" + _status + "' ";
                comando += "where id_ocorrencia = '" + _idOco + "'";
            }
            ObjBancoDados.ExecutaComando(comando);
        }
    }
}
