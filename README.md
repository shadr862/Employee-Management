# 🏢 Employee Dashboard (Interview Task)

This project is an **enhanced Employee Management Dashboard** built with **Angular** (frontend) and **ASP.NET Core Web API** (backend). It simulates a real-world admin panel with feature-rich, interactive functionalities.

---

## 📸 Project Preview

### 🏠 Dashboard 

![Dashboard](https://github.com/shadr862/Employee-Management/blob/main/Images/Dashboard.PNG)

### 👥 Employee Management

* Full CRUD with persistent storage (Make API With Entity Framework)
* Soft delete (mark as Archived)
* Enhanced edit flow using Drawer with pre-filled form and "Save & Continue Editing"
* Performance Score (1–100) with AntD Progress
  ![Add Employee](https://github.com/shadr862/Employee-Management/blob/main/Images/Add.PNG)
  ![Edit Employee](https://github.com/shadr862/Employee-Management/blob/main/Images/Edit.PNG)
  ![Soft Delete using Archive Before](https://github.com/shadr862/Employee-Management/blob/main/Images/Before_Archive.PNG)
  ![Permanent Delete or UnArchive](https://github.com/shadr862/Employee-Management/blob/main/Images/After_Archive.PNG)


### 🔍 Global Search & Filters

* Debounced global search (500ms)
* Multi-filter system: Department, Status, Joining Date Range
  ![Global Search](https://github.com/shadr862/Employee-Management/blob/main/Images/Search_result.PNG)
  ![not found search](https://github.com/shadr862/Employee-Management/blob/main/Images/Search_not_found.PNG)

### ↕️  Pagination

* Sorting on Name, Department, Joining Date
* Sort state persists in localStorage
* AntD Table pagination with items-per-page selector
  ![Sorting](https://github.com/shadr862/Employee-Management/blob/main/Images/Sorting%20and%20Filtering.PNG)
  ![Pagination](https://github.com/shadr862/Employee-Management/blob/main/Images/pagination.PNG)

### 📱 Responsive Layout

* Table View (default) and Card View toggle
  ![Table View](https://github.com/shadr862/Employee-Management/blob/main/Images/Table_view.PNG)
  ![Card View](https://github.com/shadr862/Employee-Management/blob/main/Images/Card_view.PNG)

### 📴 Empty State

* Display friendly image + message when no employees match filters
  ![Empty State](https://github.com/shadr862/Employee-Management/blob/main/Images/Empty_state.PNG)

### 🔔 Toast Notifications

* Add/Edit/Delete notifications using Ant Design message/notification
  ![Toast Notifications](https://github.com/shadr862/Employee-Management/blob/main/Images/Notification.PNG)

---

## 🚀 Features

* Full CRUD with persistent storage
* Enhanced edit flow with Drawer
* Soft delete (Archived) and toggle view
* Global debounced search and multi-filters
* Sorting and pagination with state persistence
* Responsive Table/Card layout
* Form validation and error handling
* Performance score with progress bar

---

## 📂 Project Structure

```bash
EmployeeDashboard/
├── api/               # ASP.NET Core Web API backend
│   ├── Controllers/
│   ├── Services/
│   └── Data/
├── angular/           # Angular frontend
│   ├── components/
│   ├── services/
│   └── pages/
```
