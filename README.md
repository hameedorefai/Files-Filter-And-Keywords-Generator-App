
### Overview
This desktop application, written in C# using WinForms, is designed for managing courses, keywords, and file filtering.
 It operates using a 3-tier architecture, which includes a presentation layer, business logic layer, and data access layer.
The application allows users to add, update, and delete courses, generate and manage keywords, and filter files based on specific criteria.

### Technologies Used
- **Programming Language:** C#
- **User Interface:** Windows Forms (WinForms)
- **Database:** SQL Server
- **Data Access**: ADO.NET
- **Storage:** Course data and keywords and operation logs

### Program Components

#### User Interfaces (WinForms):
- **frmMain:** The main interface of the application, including controls for managing paths and filtering files.
- **frmAddCourse:** Form for adding a new course.
- **frmManageCourses:** Form for managing Courses.
- **frmManageKeywords:** Form for managing keywords for a specific course.
- **frmOperationLog:** Form for displaying the operation log.

#### Business Logic:
- **clsCourse:** Class for managing course data.
- **clsKeyword:** Class for managing keywords.
- **clsPath:** Class for managing paths.
- **Filtering Process:**  
A class responsible for filtering and managing files based on course-related keywords. It performs the following functions:

1. **Filtering Files:** The `FilterFiles` method iterates through a list of courses and processes files from a source directory.
                         It checks each file's name against the list of keywords associated with each course.

2. **Directory Management:** For each course, it creates a subdirectory to store filtered files if it does not already exist in the database.

3. **File Copying:** Files matching any of the keywords are copied to the respective course's subdirectory. 

- **Logging Operations:** The class maintains logs of operations, noting successes and failures during the file filtering process.
                            It logs detailed information about each file operation and any encountered errors.


- **clsKeywordGenerator**

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


 **Additional Notes:**
- The class tailored to handle Arabic script complexities and integrates numeric data effectively.


#### Data Access:
- **clsCourseData:** Class for performing CRUD operations on course data.
- **clsKeywordData:** Class for managing CRUD operations related to keywords.
- **clsOperationLogData:** Class for storing and displaying operation logs.



### User Interface
- **frmMain:** Includes options for managing paths, filtering files, and viewing Courses lists.
  
https://github.com/user-attachments/assets/9c14d023-d4e4-4917-9501-2c25c33e1a5d

- **Filter Files:** Filters files based on specified criteria.

https://github.com/user-attachments/assets/0f046ad5-fc24-4259-a50b-3cc67a1fe39c




- **frmManageCourses:** Form for managing Courses.
- 
https://github.com/user-attachments/assets/e335ce2d-0d2c-42c1-bc5d-711a1725ca42



- **frmAddCourse:** Form for adding a new course with input validation.

https://github.com/user-attachments/assets/1e143f7c-ac3b-475f-87e7-88f0606a62a3


- **frmManageKeywords:** Manage keywords for a specific course, with the ability to generate, add and delete keywords.


https://github.com/user-attachments/assets/ce447a7e-656b-463e-bf18-d8d1b78b71c5




- **Operation Logs:** Displays the operation log. --  Not required at this time as a Form!





### Database:

![image](https://github.com/user-attachments/assets/61eaf238-c423-42a9-9cdd-94cab4e30482)

![image](https://github.com/user-attachments/assets/821ae76a-0fec-43e0-8ca6-5a70208ffb1f)













































