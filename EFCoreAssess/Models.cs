using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("animals")]
public class Animal
{
    [Key]
    [Column("animal_id")]
    public int AnimalId { get; set; }

    [Column("name")]
    [MaxLength(50)]
    public string Name { get; set; } = null!;

    [Column("animal_species")]
    [MaxLength(25)]
    public string Species { get; set; } = null!;

    [Column("birth_year")]
    public int? BirthYear { get; set; }

    [Column("human_id")]
    public int HumanId { get; set; }

    [ForeignKey("HumanId")]
    public Human Human { get; set; } = null!;

    public override string ToString()
    {
        return $"<Animal AnimalId={AnimalId} Name={Name} Species={Species}>";
    }

}

[Table("humans")]
public class Human
{
    [Key]
    [Column("human_id")]
    public int HumanId { get; set; }

    [Column("fname")]
    [MaxLength(25)]
    public string FirstName { get; set; } = null!;

    [Column("lname")]
    [MaxLength(25)]
    public string LastName { get; set; } = null!;

    [Column("email")]
    [MaxLength(100)]
    public string Email { get; set; } = null!;

    public List<Animal> Animals { get; set; } = [];

    public override string ToString()
    {
        return $"<Human HumanId={HumanId} FirstName={FirstName}>";
    }
}
