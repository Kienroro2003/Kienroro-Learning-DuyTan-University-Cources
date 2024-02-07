package validation;

public class StudentValidate {
    public boolean checkName(String name){
        String regex = "^[a-zA-Z ]{4,50}$";
        return name.matches(regex);
    }

    public boolean checkPhoneNumber(String phoneNumber){
        String regex = "^09[1|0][0-9]{7}$";
        return phoneNumber.matches(regex);
    }

    public boolean checkDate(String date){
        String regex = "^([0-2][0-9]||3[0-1])/(0[0-9]||1[0-2])/([0-9][0-9])?[0-9][0-9]$";
        return date.matches(regex);
    }
}
