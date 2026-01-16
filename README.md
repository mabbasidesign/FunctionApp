FunctionApp
FunctionApp is a collection of Azure Functions written in C# for automating business processes such as nightly reporting, order processing, email analysis, and webhook integrations. The app leverages Azure Functions' event-driven architecture to handle tasks like processing new orders, analyzing emails, generating reports, and responding to blob storage events. It is designed for scalability, maintainability, and easy integration with other Azure services.

Features:

Automated nightly report generation
Email content analysis and processing
Webhook endpoints for new purchases and custom events
Order document management and processing
Blob storage event handling
Built with .NET 8 and Azure Functions SDK
Getting Started:

Clone the repository.
Configure your local.settings.json for secrets and connection strings.
Build and run locally using Visual Studio or Azure Functions Core Tools.
Requirements:

.NET 8 SDK
Azure Functions Core Tools (for local development)
Azure subscription (for deployment)
