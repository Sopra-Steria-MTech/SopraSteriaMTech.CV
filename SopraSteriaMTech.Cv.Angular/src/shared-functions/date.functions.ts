export function DateToShort(date: string | null): string {
    if (date == null) return "";
    var converted = new Date(date);
    return (converted.getMonth() + 1) + "-" + converted.getFullYear();
}

export function DateToLong(date: string | null): string {
    if (date == null) return "";
    var converted = new Date(date);
    return (converted.getDay() + 1) + "-" + (converted.getMonth() + 1) + "-" + converted.getFullYear();
}

