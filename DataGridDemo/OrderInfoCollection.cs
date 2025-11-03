using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDemo
{
    public class OrderInfoCollection
    {
        private ObservableCollection<OrderInfo> _orders;

        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public OrderInfoCollection()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        private void GenerateOrders()
        {
            _orders.Clear();

            _orders.Add(new OrderInfo(1001, "Maria", "Germany", "ALFKI", "Berlin"));
            _orders.Add(new OrderInfo(1002, "Ana", "Mexico", "ANATR", "Mexico City"));
            _orders.Add(new OrderInfo(1003, "Antonio", "Mexico", "ANTON", "Guadalajara"));
            _orders.Add(new OrderInfo(1004, "Thomas", "UK", "AROUT", "London"));
            _orders.Add(new OrderInfo(1005, "Christina", "Sweden", "BERGS", "Stockholm"));
            _orders.Add(new OrderInfo(1006, "Hanna", "Germany", "BLAUS", "Mannheim"));
            _orders.Add(new OrderInfo(1007, "Frederique", "France", "BLONP", "Strasbourg"));
            _orders.Add(new OrderInfo(1008, "Martin", "Spain", "BOLID", "Madrid"));
            _orders.Add(new OrderInfo(1009, "Laurence", "France", "BONAP", "Marseille"));
            _orders.Add(new OrderInfo(1010, "Elizabeth", "Canada", "BOTTM", "Vancouver"));
            _orders.Add(new OrderInfo(1011, "Laura", "USA", "LAURA", "Seattle"));
            _orders.Add(new OrderInfo(1012, "David", "USA", "DAVID", "Austin"));
            _orders.Add(new OrderInfo(1013, "Sophia", "Italy", "SOPHI", "Rome"));
            _orders.Add(new OrderInfo(1014, "Daniel", "UK", "DANUK", "Manchester"));
            _orders.Add(new OrderInfo(1015, "Emma", "Ireland", "EMIRL", "Dublin"));
            _orders.Add(new OrderInfo(1016, "Lucas", "Portugal", "LUCPT", "Lisbon"));
            _orders.Add(new OrderInfo(1017, "Olivia", "Austria", "OLIAT", "Vienna"));
            _orders.Add(new OrderInfo(1018, "Noah", "Norway", "NOANO", "Oslo"));
            _orders.Add(new OrderInfo(1019, "Mia", "Denmark", "MIADK", "Copenhagen"));
            _orders.Add(new OrderInfo(1020, "Ethan", "Switzerland", "ETHCH", "Zurich"));
        }
    }
}
