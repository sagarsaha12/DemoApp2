export function _camelCase(key: string): string {
    return key?.length > 0 ? key[0].toLowerCase() + key.slice(1) : key;
}

export function _toSentenceCase(str: string): string {
    if (!str) return '';
    return str.charAt(0).toUpperCase() + str.slice(1).toLowerCase();
}

export const DEFAULT_PAGESIZE = 10;

export const RegExGuid = /^[0-9a-f]{8}-[0-9a-f]{4}-[1-5][0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}$/i;
