import styles from "./RegistrationFrom.module.css";

export function Select({ name, options = [], errors, register }) {
  const required = "Pole wymagane";
  return (
    <>
      <select
        name={name}
        {...register(name, { required })}
        className={styles.field__select}
      >
        {options.map((option) => (
          <option key={option.value} name={option.value}>
            {option.label}
          </option>
        ))}
      </select>
      {errors[name] !== undefined && (
        <p className={styles.field__error}>{errors[name]?.message}</p>
      )}
    </>
  );
}
