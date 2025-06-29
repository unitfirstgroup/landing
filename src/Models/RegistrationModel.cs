using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UnitFirst.Landing.Models;

public class RegistrationModel : ObservableValidator
{
    private string? _firstName;

    [Required]
    [MinLength(2)]
    [MaxLength(30)]
    public string? FirstName
    {
        get => _firstName;
        set => SetProperty(ref _firstName, value, true);
    }

    private string? _lastName;

    [Required]
    [MinLength(2)]
    [MaxLength(30)]
    public string? LastName
    {
        get => _lastName;
        set => SetProperty(ref _lastName, value, true);
    }

    private string? _organization;

    [Required]
    [MinLength(2)]
    [MaxLength(30)]
    public string? Organization
    {
        get => _organization;
        set => SetProperty(ref _organization, value, true);
    }

    private string? _phone;

    [Required]
    [MinLength(2)]
    [MaxLength(10)]
    public string? Phone
    {
        get => _phone;
        set => SetProperty(ref _phone, value, true);
    }

    
    private string? _site;

    [Required]
    [MinLength(2)]
    [MaxLength(30)]
    public string? Site
    {
        get => _site;
        set => SetProperty(ref _site, value, true);
    }

    private int? _visitors;

    [Required]
    public int? Visitors
    {
        get => _visitors;
        set => SetProperty(ref _visitors, value, true);
    }

    private string? _email;

    [Required]
    public string? Email
    {
        get => _email;
        set => SetProperty(ref _email, value, true);
    }

    private string? _selectedDomain;

    [Required]
    public string? SelectedDomain
    {
        get => _selectedDomain;
        set => SetProperty(ref _selectedDomain, value, true);
    }
    
    private ObservableCollection<string> _domains;

    public ObservableCollection<string> Domains
    {
        get => _domains;
        set => SetProperty(ref _domains, value, true);
    }

    private string? _idea;

    [Required]
    [MinLength(2)]
    [MaxLength(100)]
    public string? Idea
    {
        get => _idea;
        set => SetProperty(ref _idea, value, true);
    }


    private string? _password;

    [Required]
    public string? Password
    {
        get => _password;
        set => SetProperty(ref _password, value, true);
    }

    private string? _confirmPassword;

    [Required]
    public string? ConfirmPassword
    {
        get => _confirmPassword;
        set => SetProperty(ref _confirmPassword, value, true);
    }

    private bool _isAgreeTerms;

    public bool IsAgreeTerms
    {
        get => _isAgreeTerms;
        set => SetProperty(ref _isAgreeTerms, value, true);
    }

    public void Validate() => ValidateAllProperties();
}