
Console.WriteLine("Bienvenido a mi lista de Contactes");

//names, lastnames, addresses, telephones, emails, ages, bestfriend
bool running = true;
List<int> ids = new List<int>();
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> telephones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();

while (running)
{
    Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   5. Eliminar Contacto    6. Salir");
    Console.WriteLine("Digite el número de la opción deseada");

    int typeOption = Convert.ToInt32(Console.ReadLine());

    switch (typeOption)
    {
        case 1:
            AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;

        case 2: //View contacts
            Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
            Console.WriteLine($"____________________________________________________________________________________________________________________________");
            foreach (var id in ids)
            {
                string isBestFriendStr = (bestFriends[id] == true) ? "Si" : "No";
                Console.WriteLine($"{names[id]}         {lastnames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
            }
            break;

        case 3: //Search contacts
            Console.WriteLine("Buscar contacto por: 1. Nombre  2. Apellido  3. Teléfono");
            int searchOption = Convert.ToInt32(Console.ReadLine());
            SearchContact(searchOption, names, lastnames, telephones);
            break;

        case 4: //Modify contact
            Console.WriteLine("Ingrese el ID del contacto que desea modificar:");
            int modifyId = Convert.ToInt32(Console.ReadLine());
            ModifyContact(modifyId, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;

        case 5: //Delete contact
            Console.WriteLine("Ingrese el ID del contacto que desea eliminar:");
            int deleteId = Convert.ToInt32(Console.ReadLine());
            DeleteContact(deleteId, ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            break;

        case 6:
            running = false;
            break;

        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }
}

static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el nombre de la persona");
    string name = Console.ReadLine();
    Console.WriteLine("Digite el apellido de la persona");
    string lastname = Console.ReadLine();
    Console.WriteLine("Digite la dirección");
    string address = Console.ReadLine();
    Console.WriteLine("Digite el telefono de la persona");
    string phone = Console.ReadLine();
    Console.WriteLine("Digite el email de la persona");
    string email = Console.ReadLine();
    Console.WriteLine("Digite la edad de la persona en números");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");
    bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

    var id = ids.Count + 1;
    ids.Add(id);
    names.Add(id, name);
    lastnames.Add(id, lastname);
    addresses.Add(id, address);
    telephones.Add(id, phone);
    emails.Add(id, email);
    ages.Add(id, age);
    bestFriends.Add(id, isBestFriend);
}

static void SearchContact(int searchOption, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> telephones)
{
    Console.WriteLine("Ingrese el valor de búsqueda:");
    string searchValue = Console.ReadLine().ToLower();

    foreach (var id in names.Keys)
    {
        if ((searchOption == 1 && names[id].ToLower().Contains(searchValue)) ||
            (searchOption == 2 && lastnames[id].ToLower().Contains(searchValue)) ||
            (searchOption == 3 && telephones[id].ToLower().Contains(searchValue)))
        {
            Console.WriteLine($"ID: {id} - Nombre: {names[id]} {lastnames[id]} - Teléfono: {telephones[id]}");
        }
    }
}

static void ModifyContact(int id, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    if (!names.ContainsKey(id))
    {
        Console.WriteLine("ID no encontrado.");
        return;
    }

    Console.WriteLine("Modificar: 1. Nombre  2. Apellido  3. Dirección  4. Teléfono  5. Email  6. Edad  7. Mejor amigo");
    int fieldOption = Convert.ToInt32(Console.ReadLine());
    switch (fieldOption)
    {
        case 1:
            Console.WriteLine("Nuevo nombre:");
            names[id] = Console.ReadLine();
            break;
        case 2:
            Console.WriteLine("Nuevo apellido:");
            lastnames[id] = Console.ReadLine();
            break;
        case 3:
            Console.WriteLine("Nueva dirección:");
            addresses[id] = Console.ReadLine();
            break;
        case 4:
            Console.WriteLine("Nuevo teléfono:");
            telephones[id] = Console.ReadLine();
            break;
        case 5:
            Console.WriteLine("Nuevo email:");
            emails[id] = Console.ReadLine();
            break;
        case 6:
            Console.WriteLine("Nueva edad:");
            ages[id] = Convert.ToInt32(Console.ReadLine());
            break;
        case 7:
            Console.WriteLine("¿Es mejor amigo? 1. Si 2. No:");
            bestFriends[id] = Convert.ToInt32(Console.ReadLine()) == 1;
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}

static void DeleteContact(int id, List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    if (!ids.Contains(id))
    {
        Console.WriteLine("ID no encontrado.");
        return;
    }

    ids.Remove(id);
    names.Remove(id);
    lastnames.Remove(id);
    addresses.Remove(id);
    telephones.Remove(id);
    emails.Remove(id);
    ages.Remove(id);
    bestFriends.Remove(id);

    Console.WriteLine($"Contacto con ID {id} eliminado.");
}