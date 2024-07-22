
### Overview
This desktop application, written in C# using WinForms, is designed for managing courses, keywords, and file filtering.
 It operates using a 3-tier architecture, which includes a presentation layer, business logic layer, and data access layer.
The application allows users to add, update, and delete courses, generate and manage keywords, and filter files based on specific criteria.

### Technologies Used
- **Programming Language:** C#
- **User Interface:** Windows Forms (WinForms)
- **Database:** SQL Server
- **Storage:** Course data and keywords and operation logs

### Program Components

#### User Interfaces (WinForms):
- **frmMain:** The main interface of the application, including controls for managing paths and filtering files.
- **frmAddCourse:** Form for adding a new course.
- **frmManageKeywords:** Form for managing keywords for a specific course.
- **frmOperationLog:** Form for displaying the operation log.

#### Business Logic:
- **clsCourse:** Class for managing course data.
- **clsKeyword:** Class for managing keywords.
- - **clsPath:** Class for managing paths.
-**clsFilteringProcess:**  
A class responsible for filtering and managing files based on course-related keywords. It performs the following functions:

1. **Filtering Files:** The `FilterFiles` method iterates through a list of courses and processes files from a source directory.
                         It checks each file's name against the list of keywords associated with each course.

2. **Directory Management:** For each course, it creates a subdirectory to store filtered files if it does not already exist in the database.

3. **File Copying:** Files matching any of the keywords are copied to the respective course's subdirectory. 

4. **Logging Operations:** The class maintains logs of operations, noting successes and failures during the file filtering process.
                            It logs detailed information about each file operation and any encountered errors.


**`clsKeywordGenerator`**

A static class designed for generating and refining keywords based on course names and numbers, with a focus on handling Arabic script variations and formatting.
This class is crucial for creating a comprehensive set of keywords that improve search and filtering capabilities.

 **Responsibilities:**

1. **Keyword Generation:**
   - Produces a variety of keywords from course names and numbers to enhance search and filtering.
   - Incorporates course numbers into keywords to ensure that variations are specific and relevant.

2. **Arabic Script Variations:**
   - **Unification of Alif Variants:** Generates keyword variations by substituting different forms of the letter "Alif" (أ, إ, آ, ا) to account for common Arabic script variations.
   - **Handling Specific Characters:** Includes methods to handle Arabic script specifics like removing Hamza (ء), replacing "ة" with "ه", and managing the definite article "ال".

3. **Keyword Formatting:**
   - **Single Words:** Creates keywords from single words in the course name, applying various transformations such as removing Hamza, replacing "ة" with "ه", and adding or removing "ال".
   - **Double Words:** Generates combinations of two words from the course name, producing keywords with multiple variations. It includes different permutations and integrates course numbers.

4. **Utility Methods:**
   - **`RemoveDoublicatedKeywords`**: Filters out duplicate keywords and trims whitespace to ensure a clean and concise list.
   - **`ContainsArabic`**: Determines if a course name contains Arabic characters, which is essential for applying appropriate transformations.
   - **`_CleanCouresNo`**: Cleans course numbers by removing unwanted characters, particularly slashes, to ensure consistency.


### **Additional Notes:**
- The class ensures comprehensive keyword coverage by combining different variations and formatting options.
- It is tailored to handle Arabic script complexities and integrates numeric data effectively.


#### Data Access:
- **clsCourseData:** Class for performing CRUD operations on course data.
- **clsKeywordData:** Class for managing CRUD operations related to keywords.
- **clsOperationLogData:** Class for storing and displaying operation logs.



### User Interface
- **frmMain:** Includes options for managing paths, filtering files, and viewing Courses lists.
https://github.com/user-attachments/assets/9c14d023-d4e4-4917-9501-2c25c33e1a5d

- **Filter Files:** Filters files based on specified criteria.

- **frmManageCourses:** Form for adding a new course with input validation.

https://github.com/user-attachments/assets/e335ce2d-0d2c-42c1-bc5d-711a1725ca42


- 
- **frmAddCourse:** Form for adding a new course with input validation.
https://github.com/user-attachments/assets/1e143f7c-ac3b-475f-87e7-88f0606a62a3


- **frmManageKeywords:** Manage keywords for a specific course, with the ability to add and delete keywords.

https://github.com/user-attachments/assets/23eb9f2b-c966-4385-b3e9-408122982883


- **frmOperationLog:** Displays the operation log. --  Not required at this time as a Form!
- https://github.com/user-attachments/assets/bfc713b0-4e4c-4123-a0ee-15105489bee3





### Database :
![image](https://github.com/user-attachments/assets/b5d403fc-445d-4d0e-9545-83ff6af8ba92)
![image](https://github.com/user-attachments/assets/99c2e29c-6f5c-4037-969b-239922dda8d0)
![image](https://github.com/user-attachments/assets/82160b04-948a-4298-b39f-d727a314081f)
![image](https://github.com/user-attachments/assets/0f641c97-e5de-49ae-8c61-9363b52dffc6)
![image](https://github.com/user-attachments/assets/beccb800-2cf4-4a15-a6b6-349d78edfb5b)
![image](https://github.com/user-attachments/assets/0b5ac8ce-d4dc-4a6d-a976-a8fee9a3fb23)


