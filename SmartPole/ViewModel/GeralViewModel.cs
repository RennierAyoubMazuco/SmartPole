using SmartPole.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPole.ViewModel
{
    public class GeralViewModel
    {
        public List<string> Regioes { get; set; }
        public List<SensorModel> Sensores { get; set; }
        public GeralViewModel()
        {
            Regioes = new List<string>()
            {
                "Santo André",
                "São Bernardo",
                "São Caetano",
                "Diadema",
                "Mauá",
                "Riberão Pires"
            };

            Sensores = new List<SensorModel>()
            {
                new SensorModel(){ Descricao="Sensor1", Data=DateTime.Now},
                new SensorModel(){ Descricao="Sensor2", Data=DateTime.Now.AddDays(-1)},
                new SensorModel(){ Descricao="Sensor3", Data=DateTime.Now.AddDays(-2)},
            };
        }
    }
}
