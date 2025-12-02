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
  ![Add Employee](your-add-employee-image-link-here)
  ![Edit Employee](your-edit-employee-image-link-here)
  ![Soft Delete using Archive Before](your-employee-detail-image-link-here)
  ![Permanent Delete or UnArchive](your-employee-detail-image-link-here)


### 🔍 Global Search & Filters

* Debounced global search (500ms)
* Multi-filter system: Department, Status, Joining Date Range
  ![Global Search](your-global-search-image-link-here)
  ![not found search](your-filters-image-link-here)

### ↕️  Pagination

* Sorting on Name, Department, Joining Date
* Sort state persists in localStorage
* AntD Table pagination with items-per-page selector
  ![Sorting](your-sorting-image-link-here)
  ![Pagination](your-pagination-image-link-here)

### 📱 Responsive Layout

* Table View (default) and Card View toggle
  ![Table View](your-table-view-image-link-here)
  ![Card View](your-card-view-image-link-here)

### 📴 Empty State

* Display friendly image + message when no employees match filters
  ![Empty State](your-empty-state-image-link-here)

### 🔔 Toast Notifications

* Add/Edit/Delete notifications using Ant Design message/notification
  ![Toast Notifications](your-toast-image-link-here)

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
