using System;

namespace Practie
{
    public class ContractHiring
    {
        private string _id;
        private Vehicle _vehicle;
        private Person _employee;
        private Person _customer;
        private int _hiring;
        private double _cost;
        private DateTime _startDate;
        private ManageVehicle _manageVehicle;

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public Vehicle Vehicle
        {
            get => _vehicle;
            set => _vehicle = value;
        }

        public Person Employee
        {
            get => _employee;
            set => _employee = value;
        }

        public Person Customer
        {
            get => _customer;
            set => _customer = value;
        }

        public int Hiring
        {
            get => _hiring;
            set => _hiring = value;
        }

        public double Cost
        {
            get => _cost;
            set => _cost = value;
        }

        public DateTime StartDate
        {
            get => _startDate;
            set => _startDate = value;
        }

        public ManageVehicle ManageVehicle
        {
            get => _manageVehicle;
            set => _manageVehicle = value;
        }

        public ContractHiring()
        {
        }

        public int getPrice()
        {
            if (this._vehicle is Truck) return this._hiring *  500000;
            if (this._vehicle is Travel)
            {
                Travel travel = this._vehicle as Travel;
                if (travel.Seat <= 5) return this._hiring * 500000;
                if (travel.Seat <= 7) return this._hiring * 700000;
            }

            return this._hiring * 1000000;
        }

        public ContractHiring(string id, Vehicle vehicle, Person employee, Person customer, int hiring, double cost, DateTime startDate, ManageVehicle manageVehicle)
        {
            _id = id;
            _vehicle = vehicle;
            _employee = employee;
            _customer = customer;
            _hiring = hiring;
            _cost = cost;
            _startDate = startDate;
            _manageVehicle = manageVehicle;
        }

        public void inputContractHiring()
        {
            this._manageVehicle = new ManageVehicle();
            _manageVehicle.menu();
            Console.WriteLine("Enter id vehicle: ");
            string plateNumber = Console.ReadLine();
            if (_manageVehicle.isExistVehicle(plateNumber))
            {
                this._vehicle = _manageVehicle.getVehicleByPlateNumber(plateNumber);
                Console.WriteLine("==============Information Customer==============");
                this._customer = new Customer();
                this._customer.input();
                Console.WriteLine("==============Information Employee==============");
                this._employee = new Employee();
                this._employee.input();
            }
        }

        public void display()
        {
            this._employee.display();
            this._customer.display();
            this._vehicle.display();
            Console.WriteLine($"Price: {this.getPrice()}");
        }
        
        
    }
}