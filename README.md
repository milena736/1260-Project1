Milena Cressman, CSCI-1260,
The world I created is a library system. It manages loans, members, and items.

1.	The hollow diamonds in my UML diagram represent an aggregation. One example is the
relationship between the Library(manager) class and the Members class. The Library has a list
of members and the Members class would still exist if Library was deleted. My abstract root class LibraryItem
has a composition relationship with the Loan class. Loan uses library items to create a loan record. If the
LibraryItem class was deleted the Loan class would not be able to function. Removing the LibraryItem root class
would change each of the other relationships.

2. 	My interface is ILoanable. It contains a bool to determine if an item is available. I decided to make it an interface
because multiple needed to implement it to determine if an item was available. It would also be useful to have if items
 were hypothetically added to the program. It would also make any future changes to the loan logic less complicated.
It is implemented by Loan and LibraryItem.

3.	I would add a DVD class or a class to calculate members’ late fees. To add a DVD class, I could extend off LibraryItem.
Adding this class would not affect the other classes or relationships. The manager class Library would be unchanged. 
