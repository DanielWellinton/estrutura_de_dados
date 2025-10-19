using CompanyTree;

Tree<Person> tree = new Tree<Person>();
tree.Root = new TreeNode<Person>();
tree.Root.Data = new Person(100, "Marcin Jamro", "CEO");

tree.Root.Children =
    new List<TreeNode<Person>>
    {
        new TreeNode<Person>() {
            Data = new Person(1, "John Smith", "Head of Development"),
            Parent = tree.Root,
        },
        new TreeNode<Person>() {
            Data = new Person(50, "Mary Fox", "Head of Research"),
            Parent = tree.Root,
        },
        new TreeNode<Person>() {
            Data = new Person(150, "Lily Smith", "Head of Sales"),
            Parent = tree.Root,
        },
    };

tree.Root.Children[2].Children =
    new List<TreeNode<Person>>()
    {
        new TreeNode<Person>() {
            Data = new Person(30, "Anthony Black", "Sales Specialist"),
            Parent = tree.Root.Children[2],
        },
    };

