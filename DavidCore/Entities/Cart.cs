using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidCore.Entities
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(Device device, int quantity)
        {
            CartLine line = lineCollection
                .Where(p => p.Device.DeviceId == device.DeviceId)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Device = device,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Device device)
        {
            lineCollection.RemoveAll(l => l.Device.DeviceId == device.DeviceId);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => (int)e.Device.Radius * e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class CartLine
    {
        public Device Device { get; set; }
        public int Quantity { get; set; }
    }
}
